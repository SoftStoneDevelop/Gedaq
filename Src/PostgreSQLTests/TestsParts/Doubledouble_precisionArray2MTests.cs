

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
    internal partial interface IDoubleListdouble_precisionArray
    {
    }
    
    internal partial class DoubleListdouble_precisionArray : IDoubleListdouble_precisionArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2mi(
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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
INSERT INTO public.doubledouble_precisionarray2mi(
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
            queryMapType: typeof(Doubledouble_precisionArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, 1055924108, 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModelInner(connection, 702483271, 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, 1531070413, 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerAsync(connection, 871432658, 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, 328876671, 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

}, null);
                Assert.That(id, Is.EqualTo(328876671));

                id =  ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturning(connection, 301179049, 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

});
                Assert.That(id, Is.EqualTo(301179049));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1288862508, 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

});
                Assert.That(id, Is.EqualTo(1288862508));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1553141234, 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

}, null);
                Assert.That(id, Is.EqualTo(1553141234));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 2096945914, 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

});
                Assert.That(id, Is.EqualTo(2096945914));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 943934523, 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

});
                Assert.That(id, Is.EqualTo(943934523));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1073906827, 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

});
                Assert.That(id, Is.EqualTo(1073906827));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 631829717, 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

}, null);
                Assert.That(id, Is.EqualTo(631829717));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 303346654, 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

});
                Assert.That(id, Is.EqualTo(303346654));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1061791218, 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

}, null);
                Assert.That(id, Is.EqualTo(1061791218));

                id = await ((IDoubleListdouble_precisionArray)this).InsertModelInnerReturningAsync(connection, 1565749339, 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

});
                Assert.That(id, Is.EqualTo(1565749339));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, 1080551768, 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDoubleListdouble_precisionArray)this).InsertModel(connection, 542376855, 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

}, null, 1055924108);
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

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, 1629869264, 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDoubleListdouble_precisionArray)this).InsertModelAsync(connection, 721719019, 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

}, null, 702483271);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.doubledouble_precisionarray2m(
	id,
    value,
    nullablevalue,
    doubledouble_precisionarray2mi_id
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
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Doubledouble_precisionArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Double>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483640)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "doubledouble_precisionarray2mi_id", 
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
                List<Doubledouble_precisionArray2M> models = null;
                Doubledouble_precisionArray2M model = null;

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, 1238262196, 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, 80045024, 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

}, 1531070413).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80045024));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1531070413));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, 573744795, 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDoubleListdouble_precisionArray)this).InsertModelReturning(connection, 1781407133, 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

}, 871432658).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Doubledouble_precisionArray2M> models = null;
                Doubledouble_precisionArray2M model = null;

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1719890108, 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 617601703, 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

}, 328876671).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1950593016, 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1275518886, 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

}, null, 301179049).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 605378088, 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1432590076, 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

}, 1288862508).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 464684447, 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 542480497, 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

}, null, 1553141234).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1783637858, 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1594618448, 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

}, 2096945914).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1234671690, 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 293914351, 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

}, 943934523).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 384565805, 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1055051763, 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

}, null, 1073906827).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 481894025, 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

}, 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1562869027, 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

}, null, 631829717).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 134968338, 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 707981606, 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

}, null, 303346654).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 2113239501, 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1032488037, 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

}, null, 1061791218).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 233409490, 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDoubleListdouble_precisionArray)this).InsertModelReturningAsync(connection, 1528487768, 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

}, 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

}, 1565749339).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)
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
                var models =  ((IDoubleListdouble_precisionArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80045024));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1531070413));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

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
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IDoubleListdouble_precisionArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80045024));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1531070413));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

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
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
FROM public.doubledouble_precisionarray2m m
LEFT JOIN public.doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDoubleListdouble_precisionArray)
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
                var models =  ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80045024));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1531070413));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

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
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80045024));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1531070413));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

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
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                 using var cmd =  ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 80045024);
                var models =  ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(29));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                model = models[27];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await using var cmd = await ((IDoubleListdouble_precisionArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDoubleListdouble_precisionArray)this).SetDbConnectionSelectModelParametrs(cmd, 384565805);
                var models = await ((IDoubleListdouble_precisionArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(25));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
            asPartInterface: typeof(IDoubleListdouble_precisionArray)
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
                 foreach(var batchResult in ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatch(connection, 542376855, 134968338))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(22));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                        model = models[27];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await foreach(var batchResult in ((IDoubleListdouble_precisionArray)this).DbConnectionSelectModelBatchAsync(connection, 1594618448, 1275518886))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(10));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_doubledouble_precisionarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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
FROM public.binary_doubledouble_precisionarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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

                var importCollection = new List<Doubledouble_precisionArray2MI>(7);

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 301179049,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 303346654,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 328876671,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 631829717,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 702483271,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 871432658,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 943934523,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(301179049));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(303346654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(328876671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(631829717));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(702483271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(871432658));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(943934523));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                new Doubledouble_precisionArray2MI
                {
                    Id = 1055924108,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 1061791218,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 1073906827,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 1288862508,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 1531070413,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 1553141234,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 1565749339,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

}
                });

                importCollection.Add(
                new Doubledouble_precisionArray2MI
                {
                    Id = 2096945914,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(301179049));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(303346654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(328876671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(631829717));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(702483271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(871432658));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(943934523));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(1055924108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(1061791218));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1073906827));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1288862508));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1531070413));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

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
                Assert.That(model.Id, Is.EqualTo(1553141234));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(1565749339));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(2096945914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
COPY public.binary_doubledouble_precisionarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
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
FROM public.binary_doubledouble_precisionarray2m m
LEFT JOIN public.binary_doubledouble_precisionarray2mi mi ON mi.id = m.doubledouble_precisionarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
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

                var importCollection = new List<Doubledouble_precisionArray2M>(15);

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 80045024,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

},

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 1531070413
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 134968338,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 233409490,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 293914351,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

},

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 943934523
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 384565805,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 464684447,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 481894025,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 542376855,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 1055924108
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 542480497,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 1553141234
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 573744795,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 605378088,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 617601703,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

},

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 328876671
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 707981606,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 303346654
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 721719019,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 702483271
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1032488037,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 1061791218
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80045024));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1531070413));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

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
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                new Doubledouble_precisionArray2M
                {
                    Id = 1055051763,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 1073906827
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1080551768,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1234671690,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1238262196,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1275518886,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 301179049
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1432590076,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

},

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 1288862508
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1528487768,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

},

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 1565749339
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1562869027,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

},
                    NullableValue = null,

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 631829717
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1594618448,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

},

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 2096945914
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1629869264,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1719890108,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1781407133,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

},

                    ModelInner = new Doubledouble_precisionArray2MI 
                    {
                        Id = 871432658
                    }

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1783637858,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 1950593016,
                    Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Doubledouble_precisionArray2M
                {
                    Id = 2113239501,
                    Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(80045024));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1531070413));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

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
                Assert.That(model.Id, Is.EqualTo(134968338));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(233409490));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

};
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
                Assert.That(model.Id, Is.EqualTo(293914351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(943934523));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

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
                Assert.That(model.Id, Is.EqualTo(384565805));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(464684447));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

};
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
                Assert.That(model.Id, Is.EqualTo(481894025));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

};
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
                Assert.That(model.Id, Is.EqualTo(542376855));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1055924108));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

};
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
                Assert.That(model.Id, Is.EqualTo(542480497));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1553141234));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

};
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
                Assert.That(model.Id, Is.EqualTo(573744795));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

};
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
                Assert.That(model.Id, Is.EqualTo(605378088));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(617601703));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(328876671));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

};
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
                Assert.That(model.Id, Is.EqualTo(707981606));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(303346654));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

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
                Assert.That(model.Id, Is.EqualTo(721719019));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(702483271));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

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
                Assert.That(model.Id, Is.EqualTo(1032488037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1061791218));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

};
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
                Assert.That(model.Id, Is.EqualTo(1055051763));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1073906827));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

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
                Assert.That(model.Id, Is.EqualTo(1080551768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1234671690));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

};
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
                Assert.That(model.Id, Is.EqualTo(1238262196));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1275518886));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(301179049));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

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
                Assert.That(model.Id, Is.EqualTo(1432590076));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1288862508));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

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
                Assert.That(model.Id, Is.EqualTo(1528487768));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1565749339));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

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
                Assert.That(model.Id, Is.EqualTo(1562869027));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(631829717));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

};
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
                Assert.That(model.Id, Is.EqualTo(1594618448));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2096945914));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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
                Assert.That(model.Id, Is.EqualTo(1629869264));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

};
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
                Assert.That(model.Id, Is.EqualTo(1719890108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1781407133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(871432658));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

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
                Assert.That(model.Id, Is.EqualTo(1783637858));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1950593016));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);


                model = models[29];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2113239501));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_doubledouble_precisionarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    doubledouble_precisionarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Doubledouble_precisionArray2M),
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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray2M>(30);

                expected.Add(
                    80045024,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 80045024,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1531070413,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

}
                        }

                    }
                );

                expected.Add(
                    134968338,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 134968338,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    233409490,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 233409490,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    293914351,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 293914351,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 943934523,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

}
                        }

                    }
                );

                expected.Add(
                    384565805,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 384565805,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    464684447,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 464684447,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    481894025,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 481894025,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    542376855,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 542376855,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1055924108,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    542480497,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 542480497,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1553141234,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    573744795,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 573744795,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    605378088,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 605378088,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    617601703,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 617601703,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 328876671,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    707981606,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 707981606,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 303346654,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

}
                        }

                    }
                );

                expected.Add(
                    721719019,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 721719019,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 702483271,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

}
                        }

                    }
                );

                expected.Add(
                    1032488037,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1032488037,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1061791218,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1055051763,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1055051763,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1073906827,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

}
                        }

                    }
                );

                expected.Add(
                    1080551768,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1080551768,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1234671690,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1234671690,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1238262196,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1238262196,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1275518886,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1275518886,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 301179049,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

}
                        }

                    }
                );

                expected.Add(
                    1432590076,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1432590076,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1288862508,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

}
                        }

                    }
                );

                expected.Add(
                    1528487768,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1528487768,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1565749339,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

}
                        }

                    }
                );

                expected.Add(
                    1562869027,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1562869027,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 631829717,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1594618448,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1594618448,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 2096945914,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

}
                        }

                    }
                );

                expected.Add(
                    1629869264,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1629869264,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1719890108,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1719890108,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1781407133,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1781407133,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 871432658,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

}
                        }

                    }
                );

                expected.Add(
                    1783637858,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1783637858,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1950593016,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1950593016,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2113239501,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 2113239501,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray2M>(30);

                expected.Add(
                    80045024,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 80045024,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19031029891461304d,

0.25778141145776845d,

0.2860210447066752d,

0.6046636421588891d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.1683903240417316d,

0.9594931809140268d,

0.05221006742234291d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1531070413,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

}
                        }

                    }
                );

                expected.Add(
                    134968338,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 134968338,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6802399984969161d,

0.9832648820095921d,

0.7065716063427403d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    233409490,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 233409490,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7180302370291142d,

0.2820812472810831d,

0.6302400333105626d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.0006247145399540521d,

0.9341109215585404d,

0.5116730923778563d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    293914351,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 293914351,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.31242415492034925d,

0.7524055467398919d,

0.5906820470316404d,

0.5973356586460822d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.36190518505862346d,

0.25757028140131855d,

0.9093489458871806d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 943934523,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

}
                        }

                    }
                );

                expected.Add(
                    384565805,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 384565805,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2740476758682189d,

0.8898295728459963d,

0.7626238920051075d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    464684447,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 464684447,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7334812686270983d,

0.04225687233521058d,

0.9717675451751756d,

0.961379534204965d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.31124188473778824d,

0.6036184713736364d,

0.7389682700510577d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    481894025,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 481894025,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.3275240348798395d,

0.37493961142463994d,

0.035165457795668154d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9585217248665753d,

0.8238023312989082d,

0.7380279975762208d,

0.7113155667658527d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    542376855,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 542376855,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.2862518038418854d,

0.6190631417647546d,

0.3974391498301797d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1055924108,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    542480497,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 542480497,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6840785618379185d,

0.7710146630175899d,

0.7477184651639962d,

0.5303410920025963d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1553141234,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    573744795,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 573744795,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9697460499928763d,

0.6745307490343121d,

0.25004808654412913d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9335110959260362d,

0.3411248945120716d,

0.7450284231521257d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    605378088,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 605378088,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8075412608359724d,

0.6768193591419167d,

0.9963246580532598d,

0.7605084885647375d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    617601703,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 617601703,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.11792367884932664d,

0.4790915069252656d,

0.13048341936059293d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5116575313090377d,

0.11397658326343485d,

0.688919540977988d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 328876671,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    707981606,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 707981606,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9818926687365894d,

0.35407768003823037d,

0.11255476155242317d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 303346654,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

}
                        }

                    }
                );

                expected.Add(
                    721719019,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 721719019,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12605548533479505d,

0.8215500256091004d,

0.3217828414871482d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 702483271,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

}
                        }

                    }
                );

                expected.Add(
                    1032488037,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1032488037,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9262516290849109d,

0.27569181848910285d,

0.37463799318268465d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1061791218,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1055051763,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1055051763,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5674371327020787d,

0.26379396903939245d,

0.46801497870800957d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1073906827,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

}
                        }

                    }
                );

                expected.Add(
                    1080551768,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1080551768,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12870687569309458d,

0.042255894524057314d,

0.7751748241650266d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1234671690,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1234671690,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.544031973127789d,

0.9755290141108452d,

0.15338600506902866d,

0.3214192273345847d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.7450714329556386d,

0.8826217015887587d,

0.5927575008678654d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1238262196,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1238262196,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.05510928795944503d,

0.6905125983229271d,

0.05866521370383637d,

0.507822279111229d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1275518886,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1275518886,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.16002139736337828d,

0.5060729659261486d,

0.6562524532195549d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 301179049,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

}
                        }

                    }
                );

                expected.Add(
                    1432590076,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1432590076,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5898181159281721d,

0.10431822569707305d,

0.41347516995487243d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7965646003444165d,

0.7239207273220502d,

0.5277663095328463d,

0.3776624430512949d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1288862508,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

}
                        }

                    }
                );

                expected.Add(
                    1528487768,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1528487768,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.880471561142107d,

0.26229797579564096d,

0.5933249938708413d,

0.7366039887676326d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.003229349878094978d,

0.41446886837867536d,

0.39355256072430056d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 1565749339,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

}
                        }

                    }
                );

                expected.Add(
                    1562869027,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1562869027,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.75509088751726d,

0.678547950757997d,

0.27833026261463445d,

0.8746937957680879d,

},
                        NullableValue = null,

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 631829717,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1594618448,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1594618448,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.9542986331732227d,

0.06235442236381272d,

0.9999150306851118d,

0.6788034723903162d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.40469506727997795d,

0.6191353596177044d,

0.10257631769634656d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 2096945914,
                            Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

}
                        }

                    }
                );

                expected.Add(
                    1629869264,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1629869264,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.036166745843591586d,

0.23657123895255117d,

0.947954890166779d,

0.3894463318263438d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.6575406532714192d,

0.9197976314021913d,

0.5492166693263368d,

0.47194130631236975d,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1719890108,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1719890108,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.47653652107945954d,

0.43645780279637225d,

0.4364942300532709d,

0.4440675919218693d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1781407133,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1781407133,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.012955741853754255d,

0.5010797945578881d,

0.0223223225829553d,

0.3547991577870053d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7519440840172823d,

0.7215852258447288d,

0.926765487198446d,

0.7719779610465702d,

},

                        ModelInner = new Doubledouble_precisionArray2MI
                        {
                            Id = 871432658,
                            Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

}
                        }

                    }
                );

                expected.Add(
                    1783637858,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1783637858,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.39472724286612093d,

0.1287325905795803d,

0.7955025436190928d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1950593016,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 1950593016,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.9275225405635527d,

0.6361184795387553d,

0.9776675129736108d,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2113239501,
                    new Doubledouble_precisionArray2M
                    {
                        Id = 2113239501,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.29738730517184875d,

0.09078511105690545d,

0.8066530375191915d,

0.0982480314525439d,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Double>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_doubledouble_precisionarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Doubledouble_precisionArray2MI),
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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray2MI>(15);

                expected.Add(
                    301179049,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 301179049,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

}
                    }
                );

                expected.Add(
                    303346654,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 303346654,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

}
                    }
                );

                expected.Add(
                    328876671,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 328876671,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    631829717,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 631829717,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    702483271,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 702483271,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

}
                    }
                );

                expected.Add(
                    871432658,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 871432658,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

}
                    }
                );

                expected.Add(
                    943934523,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 943934523,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

}
                    }
                );

                expected.Add(
                    1055924108,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1055924108,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1061791218,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1061791218,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1073906827,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1073906827,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

}
                    }
                );

                expected.Add(
                    1288862508,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1288862508,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

}
                    }
                );

                expected.Add(
                    1531070413,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1531070413,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

}
                    }
                );

                expected.Add(
                    1553141234,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1553141234,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1565749339,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1565749339,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

}
                    }
                );

                expected.Add(
                    2096945914,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 2096945914,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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

                var expected = new Dictionary<System.Int32,Doubledouble_precisionArray2MI>(15);

                expected.Add(
                    301179049,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 301179049,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.7227264405125183d,

0.38297485400677855d,

0.7201187533025988d,

0.07445985088454421d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6511996628009479d,

0.7121944032354651d,

0.22423245535992542d,

}
                    }
                );

                expected.Add(
                    303346654,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 303346654,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2603507091368632d,

0.8858786288231091d,

0.7951528343688182d,

0.22411184830457254d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.48656470195544343d,

0.6336938418395698d,

0.02748582600663374d,

}
                    }
                );

                expected.Add(
                    328876671,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 328876671,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.704401891364956d,

0.12943435597592434d,

0.41153571274354983d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    631829717,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 631829717,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.18737281326079835d,

0.41929851609109814d,

0.7353873971837624d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    702483271,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 702483271,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8666469924005247d,

0.5662304902511611d,

0.06597964222709651d,

0.19665509239303736d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6621148322956948d,

0.29763031853787447d,

0.02746424379194745d,

}
                    }
                );

                expected.Add(
                    871432658,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 871432658,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.809472294092147d,

0.12629030014702847d,

0.9821517451351701d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.12655506571659447d,

0.9463148099079557d,

0.6712359269834417d,

}
                    }
                );

                expected.Add(
                    943934523,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 943934523,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.19643846491179018d,

0.5729327687193952d,

0.6936412409692528d,

0.9498156185528208d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5488008631532572d,

0.6630913174054922d,

0.7290094110938014d,

0.3659912484183393d,

}
                    }
                );

                expected.Add(
                    1055924108,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1055924108,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8916387640148705d,

0.8595009559708467d,

0.6941827336313586d,

0.23234894006177298d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1061791218,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1061791218,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.33307234073987024d,

0.8397129887540332d,

0.33861660239933744d,

0.07455711630493733d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1073906827,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1073906827,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.33171997919944407d,

0.013008090907217884d,

0.38503648809126056d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.352137244140858d,

0.8799090704591643d,

0.5635630151693423d,

0.7138312625101599d,

}
                    }
                );

                expected.Add(
                    1288862508,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1288862508,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.3141668701519815d,

0.5977481890224878d,

0.09449344901283419d,

0.06448198327110932d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.5700386341092972d,

0.003958362910522428d,

0.010312469013923575d,

0.18693310770844895d,

}
                    }
                );

                expected.Add(
                    1531070413,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1531070413,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.6633467484870689d,

0.3180657521437511d,

0.5454505700998684d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8271211768384671d,

0.9437461222851633d,

0.5826323823657918d,

0.3934230796258936d,

}
                    }
                );

                expected.Add(
                    1553141234,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1553141234,
                        Value = 
new System.Collections.Generic.List<System.Double>(3)
{
0.5836467369017537d,

0.13534220772061123d,

0.41120361826107676d,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1565749339,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 1565749339,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.910803870488319d,

0.640342890082979d,

0.046847537868411004d,

0.778421321397975d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(4)
{
0.8772925129786753d,

0.6310088665916992d,

0.5362037697733609d,

0.7500901687199586d,

}
                    }
                );

                expected.Add(
                    2096945914,
                    new Doubledouble_precisionArray2MI
                    {
                        Id = 2096945914,
                        Value = 
new System.Collections.Generic.List<System.Double>(4)
{
0.2546184357860767d,

0.47884244344721305d,

0.05398474284817667d,

0.6993910314155489d,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Double>(3)
{
0.26041912747407736d,

0.9800837063300328d,

0.8091603607834731d,

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

