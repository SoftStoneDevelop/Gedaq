

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
    internal partial interface IDecimalListnumericArray
    {
    }
    
    internal partial class DecimalListnumericArray : IDecimalListnumericArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2mi(
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
            asPartInterface: typeof(IDecimalListnumericArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
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
INSERT INTO public.decimalnumericarray2mi(
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
            queryMapType: typeof(DecimalnumericArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, 2011771634, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModelInner(connection, 945324481, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, 855649252, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelInnerAsync(connection, 1467898803, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

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

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, 1586099015, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

}, null);
                Assert.That(id, Is.EqualTo(1586099015));

                id =  ((IDecimalListnumericArray)this).InsertModelInnerReturning(connection, 1325179045, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

}, null);
                Assert.That(id, Is.EqualTo(1325179045));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 1449931619, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

});
                Assert.That(id, Is.EqualTo(1449931619));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 92400782, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

}, null);
                Assert.That(id, Is.EqualTo(92400782));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 1287556208, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

}, null);
                Assert.That(id, Is.EqualTo(1287556208));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 624368106, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

});
                Assert.That(id, Is.EqualTo(624368106));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 1163997611, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

});
                Assert.That(id, Is.EqualTo(1163997611));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 968118874, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

}, null);
                Assert.That(id, Is.EqualTo(968118874));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 1459685240, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

});
                Assert.That(id, Is.EqualTo(1459685240));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 1853049896, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

});
                Assert.That(id, Is.EqualTo(1853049896));

                id = await ((IDecimalListnumericArray)this).InsertModelInnerReturningAsync(connection, 1782954037, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

});
                Assert.That(id, Is.EqualTo(1782954037));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
            asPartInterface: typeof(IDecimalListnumericArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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

                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, 57639851, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IDecimalListnumericArray)this).InsertModel(connection, 834987876, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

}, null, 2011771634);
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

                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, 343377110, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IDecimalListnumericArray)this).InsertModelAsync(connection, 1491840006, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

}, null, 945324481);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.decimalnumericarray2m(
	id,
    value,
    nullablevalue,
    decimalnumericarray2mi_id
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
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(DecimalnumericArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)
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
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Decimal>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "decimalnumericarray2mi_id", 
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
                List<DecimalnumericArray2M> models = null;
                DecimalnumericArray2M model = null;

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, 541518300, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, 270545363, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

}, 855649252).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(270545363));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855649252));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, 91815352, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(91815352));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IDecimalListnumericArray)this).InsertModelReturning(connection, 198845625, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

}, null, 1467898803).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(198845625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1467898803));

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
                List<DecimalnumericArray2M> models = null;
                DecimalnumericArray2M model = null;

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1580017754, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1412782945, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

}, null, 1586099015).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 193888155, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(193888155));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 169652533, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

}, null, 1325179045).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(169652533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1325179045));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 2032412652, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 32262729, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

}, null, 1449931619).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32262729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1449931619));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 656087792, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1832017216, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

}, 92400782).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 166629671, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(166629671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 577938959, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

}, 1287556208).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 2093584601, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 2124641163, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

}, null, 624368106).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 781026718, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1297290090, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

}, null, 1163997611).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1648707232, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 915400433, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

}, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

}, 968118874).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1097674407, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1342660566, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

}, 1459685240).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1773585408, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1263865151, 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

}, 1853049896).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Decimal>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1158777108, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IDecimalListnumericArray)this).InsertModelReturningAsync(connection, 1145173047, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

}, 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

}, 1782954037).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(DecimalnumericArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)
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
                var models =  ((IDecimalListnumericArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32262729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1449931619));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

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
                Assert.That(model.Id, Is.EqualTo(57639851));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(91815352));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(166629671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

};
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
                Assert.That(model.Id, Is.EqualTo(169652533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1325179045));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

};
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
                Assert.That(model.Id, Is.EqualTo(193888155));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

};
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
                Assert.That(model.Id, Is.EqualTo(198845625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1467898803));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

};
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
                Assert.That(model.Id, Is.EqualTo(270545363));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855649252));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(343377110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
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
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                var models = await ((IDecimalListnumericArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32262729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1449931619));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

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
                Assert.That(model.Id, Is.EqualTo(57639851));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(91815352));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(166629671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

};
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
                Assert.That(model.Id, Is.EqualTo(169652533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1325179045));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

};
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
                Assert.That(model.Id, Is.EqualTo(193888155));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

};
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
                Assert.That(model.Id, Is.EqualTo(198845625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1467898803));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

};
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
                Assert.That(model.Id, Is.EqualTo(270545363));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855649252));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(343377110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
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
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
FROM public.decimalnumericarray2m m
LEFT JOIN public.decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(DecimalnumericArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IDecimalListnumericArray)
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
                var models =  ((IDecimalListnumericArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32262729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1449931619));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

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
                Assert.That(model.Id, Is.EqualTo(57639851));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(91815352));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(166629671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

};
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
                Assert.That(model.Id, Is.EqualTo(169652533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1325179045));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

};
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
                Assert.That(model.Id, Is.EqualTo(193888155));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

};
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
                Assert.That(model.Id, Is.EqualTo(198845625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1467898803));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

};
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
                Assert.That(model.Id, Is.EqualTo(270545363));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855649252));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(343377110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
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
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                var models = await ((IDecimalListnumericArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32262729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1449931619));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

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
                Assert.That(model.Id, Is.EqualTo(57639851));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(91815352));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(166629671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

};
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
                Assert.That(model.Id, Is.EqualTo(169652533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1325179045));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

};
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
                Assert.That(model.Id, Is.EqualTo(193888155));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

};
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
                Assert.That(model.Id, Is.EqualTo(198845625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1467898803));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

};
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
                Assert.That(model.Id, Is.EqualTo(270545363));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855649252));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(343377110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
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
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                 using var cmd =  ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 541518300);
                var models =  ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(20));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
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
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                await using var cmd = await ((IDecimalListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IDecimalListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 1773585408);
                var models = await ((IDecimalListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(4));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
            asPartInterface: typeof(IDecimalListnumericArray)
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
                 foreach(var batchResult in ((IDecimalListnumericArray)this).DbConnectionSelectModelBatch(connection, 1158777108, 1773585408))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                        Assert.That(models, Has.Count.EqualTo(4));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                await foreach(var batchResult in ((IDecimalListnumericArray)this).DbConnectionSelectModelBatchAsync(connection, 343377110, 1158777108))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(21));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
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
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
COPY public.binary_decimalnumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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
FROM public.binary_decimalnumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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

                var importCollection = new List<DecimalnumericArray2MI>(7);

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 92400782,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 624368106,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 855649252,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 945324481,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 968118874,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1163997611,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1287556208,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92400782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(624368106));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                Assert.That(model.Id, Is.EqualTo(855649252));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(945324481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(968118874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1163997611));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1287556208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                new DecimalnumericArray2MI
                {
                    Id = 1325179045,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1449931619,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1459685240,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1467898803,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1586099015,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

},
                    NullableValue = null
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1782954037,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 1853049896,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

}
                });

                importCollection.Add(
                new DecimalnumericArray2MI
                {
                    Id = 2011771634,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(92400782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(624368106));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
                Assert.That(model.Id, Is.EqualTo(855649252));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(945324481));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(968118874));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1163997611));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1287556208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(1325179045));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

};
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
                Assert.That(model.Id, Is.EqualTo(1449931619));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

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
                Assert.That(model.Id, Is.EqualTo(1459685240));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1467898803));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

};
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
                Assert.That(model.Id, Is.EqualTo(1586099015));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1782954037));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1853049896));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(2011771634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
COPY public.binary_decimalnumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
decimalnumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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
FROM public.binary_decimalnumericarray2m m
LEFT JOIN public.binary_decimalnumericarray2mi mi ON mi.id = m.decimalnumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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

                var importCollection = new List<DecimalnumericArray2M>(15);

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 32262729,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1449931619
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 57639851,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 91815352,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 166629671,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 169652533,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1325179045
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 193888155,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 198845625,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1467898803
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 270545363,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

},

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 855649252
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 343377110,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 541518300,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 577938959,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

},

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1287556208
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 656087792,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 781026718,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 834987876,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 2011771634
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 915400433,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

},

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 968118874
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32262729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1449931619));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

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
                Assert.That(model.Id, Is.EqualTo(57639851));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(91815352));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(166629671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

};
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
                Assert.That(model.Id, Is.EqualTo(169652533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1325179045));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

};
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
                Assert.That(model.Id, Is.EqualTo(193888155));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

};
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
                Assert.That(model.Id, Is.EqualTo(198845625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1467898803));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

};
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
                Assert.That(model.Id, Is.EqualTo(270545363));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855649252));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(343377110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                new DecimalnumericArray2M
                {
                    Id = 1097674407,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1145173047,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

},

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1782954037
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1158777108,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1263865151,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

},

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1853049896
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1297290090,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1163997611
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1342660566,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

},

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1459685240
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1412782945,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 1586099015
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1491840006,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 945324481
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1580017754,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1648707232,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1773585408,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 1832017216,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

},

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 92400782
                    }

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 2032412652,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 2093584601,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

},

                    ModelInner = null

                });

                importCollection.Add(
                new DecimalnumericArray2M
                {
                    Id = 2124641163,
                    Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

},
                    NullableValue = null,

                    ModelInner = new DecimalnumericArray2MI 
                    {
                        Id = 624368106
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32262729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1449931619));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

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
                Assert.That(model.Id, Is.EqualTo(57639851));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(91815352));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(166629671));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

};
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
                Assert.That(model.Id, Is.EqualTo(169652533));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1325179045));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

};
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
                Assert.That(model.Id, Is.EqualTo(193888155));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

};
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
                Assert.That(model.Id, Is.EqualTo(198845625));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1467898803));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

};
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
                Assert.That(model.Id, Is.EqualTo(270545363));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(855649252));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

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
                Assert.That(model.Id, Is.EqualTo(343377110));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(541518300));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(577938959));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1287556208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

};
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
                Assert.That(model.Id, Is.EqualTo(656087792));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(781026718));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(834987876));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2011771634));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

};
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
                Assert.That(model.Id, Is.EqualTo(915400433));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968118874));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

};
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
                Assert.That(model.Id, Is.EqualTo(1097674407));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1145173047));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1782954037));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

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
                Assert.That(model.Id, Is.EqualTo(1158777108));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

};
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
                Assert.That(model.Id, Is.EqualTo(1263865151));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1853049896));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

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
                Assert.That(model.Id, Is.EqualTo(1297290090));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1163997611));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

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
                Assert.That(model.Id, Is.EqualTo(1342660566));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1459685240));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

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
                Assert.That(model.Id, Is.EqualTo(1412782945));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1586099015));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

};
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
                Assert.That(model.Id, Is.EqualTo(1491840006));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(945324481));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

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
                Assert.That(model.Id, Is.EqualTo(1580017754));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1648707232));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1773585408));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

};
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
                Assert.That(model.Id, Is.EqualTo(1832017216));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(92400782));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

};
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
                Assert.That(model.Id, Is.EqualTo(2032412652));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2093584601));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

};
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
                Assert.That(model.Id, Is.EqualTo(2124641163));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(624368106));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
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
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
COPY public.binary_decimalnumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    decimalnumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(DecimalnumericArray2M),
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

                var expected = new Dictionary<System.Int32,DecimalnumericArray2M>(30);

                expected.Add(
                    32262729,
                    new DecimalnumericArray2M
                    {
                        Id = 32262729,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1449931619,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

}
                        }

                    }
                );

                expected.Add(
                    57639851,
                    new DecimalnumericArray2M
                    {
                        Id = 57639851,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    91815352,
                    new DecimalnumericArray2M
                    {
                        Id = 91815352,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    166629671,
                    new DecimalnumericArray2M
                    {
                        Id = 166629671,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    169652533,
                    new DecimalnumericArray2M
                    {
                        Id = 169652533,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1325179045,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    193888155,
                    new DecimalnumericArray2M
                    {
                        Id = 193888155,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    198845625,
                    new DecimalnumericArray2M
                    {
                        Id = 198845625,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1467898803,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    270545363,
                    new DecimalnumericArray2M
                    {
                        Id = 270545363,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 855649252,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

}
                        }

                    }
                );

                expected.Add(
                    343377110,
                    new DecimalnumericArray2M
                    {
                        Id = 343377110,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    541518300,
                    new DecimalnumericArray2M
                    {
                        Id = 541518300,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    577938959,
                    new DecimalnumericArray2M
                    {
                        Id = 577938959,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1287556208,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    656087792,
                    new DecimalnumericArray2M
                    {
                        Id = 656087792,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    781026718,
                    new DecimalnumericArray2M
                    {
                        Id = 781026718,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    834987876,
                    new DecimalnumericArray2M
                    {
                        Id = 834987876,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 2011771634,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    915400433,
                    new DecimalnumericArray2M
                    {
                        Id = 915400433,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 968118874,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1097674407,
                    new DecimalnumericArray2M
                    {
                        Id = 1097674407,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1145173047,
                    new DecimalnumericArray2M
                    {
                        Id = 1145173047,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1782954037,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

}
                        }

                    }
                );

                expected.Add(
                    1158777108,
                    new DecimalnumericArray2M
                    {
                        Id = 1158777108,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1263865151,
                    new DecimalnumericArray2M
                    {
                        Id = 1263865151,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1853049896,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

}
                        }

                    }
                );

                expected.Add(
                    1297290090,
                    new DecimalnumericArray2M
                    {
                        Id = 1297290090,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1163997611,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

}
                        }

                    }
                );

                expected.Add(
                    1342660566,
                    new DecimalnumericArray2M
                    {
                        Id = 1342660566,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1459685240,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

}
                        }

                    }
                );

                expected.Add(
                    1412782945,
                    new DecimalnumericArray2M
                    {
                        Id = 1412782945,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1586099015,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1491840006,
                    new DecimalnumericArray2M
                    {
                        Id = 1491840006,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 945324481,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

}
                        }

                    }
                );

                expected.Add(
                    1580017754,
                    new DecimalnumericArray2M
                    {
                        Id = 1580017754,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1648707232,
                    new DecimalnumericArray2M
                    {
                        Id = 1648707232,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1773585408,
                    new DecimalnumericArray2M
                    {
                        Id = 1773585408,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1832017216,
                    new DecimalnumericArray2M
                    {
                        Id = 1832017216,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 92400782,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2032412652,
                    new DecimalnumericArray2M
                    {
                        Id = 2032412652,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2093584601,
                    new DecimalnumericArray2M
                    {
                        Id = 2093584601,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2124641163,
                    new DecimalnumericArray2M
                    {
                        Id = 2124641163,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 624368106,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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

                var expected = new Dictionary<System.Int32,DecimalnumericArray2M>(30);

                expected.Add(
                    32262729,
                    new DecimalnumericArray2M
                    {
                        Id = 32262729,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.655690910397728m,

0.785652715161758m,

0.856028691138408m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1449931619,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

}
                        }

                    }
                );

                expected.Add(
                    57639851,
                    new DecimalnumericArray2M
                    {
                        Id = 57639851,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.276226140951004m,

0.378831567583615m,

0.113147526575083m,

0.974162758717563m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    91815352,
                    new DecimalnumericArray2M
                    {
                        Id = 91815352,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.548578866503584m,

0.57078210964279m,

0.130756898407598m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    166629671,
                    new DecimalnumericArray2M
                    {
                        Id = 166629671,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.43677040770039m,

0.560814962147485m,

0.588305592476267m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0141092268439972m,

0.917864260832451m,

0.017799523852298m,

0.878417035941148m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    169652533,
                    new DecimalnumericArray2M
                    {
                        Id = 169652533,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.290722279655277m,

0.207763652871679m,

0.227316189510097m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1325179045,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    193888155,
                    new DecimalnumericArray2M
                    {
                        Id = 193888155,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.868119270227015m,

0.492074178376949m,

0.964987422902136m,

0.484385643643421m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.00605320268847065m,

0.393875144972137m,

0.567006409120682m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    198845625,
                    new DecimalnumericArray2M
                    {
                        Id = 198845625,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.979926361096862m,

0.530147724077851m,

0.338908028912106m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1467898803,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    270545363,
                    new DecimalnumericArray2M
                    {
                        Id = 270545363,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.768361492255216m,

0.467666357608638m,

0.0358868837752597m,

0.289443593948919m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.982852325199426m,

0.734812848336458m,

0.6407494815554m,

0.474474456751008m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 855649252,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

}
                        }

                    }
                );

                expected.Add(
                    343377110,
                    new DecimalnumericArray2M
                    {
                        Id = 343377110,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.42779262584017m,

0.202388300962639m,

0.395885854266765m,

0.615416347711434m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    541518300,
                    new DecimalnumericArray2M
                    {
                        Id = 541518300,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.40325765485196m,

0.629138333825063m,

0.628605263116056m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    577938959,
                    new DecimalnumericArray2M
                    {
                        Id = 577938959,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.623931706496426m,

0.72380317166541m,

0.424228875921082m,

0.0894539005326952m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.58899504187519m,

0.372092324614822m,

0.264200828483063m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1287556208,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    656087792,
                    new DecimalnumericArray2M
                    {
                        Id = 656087792,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.956442815980362m,

0.651222192705151m,

0.304538381166535m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    781026718,
                    new DecimalnumericArray2M
                    {
                        Id = 781026718,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.868382089531674m,

0.765707938871696m,

0.895321259057175m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    834987876,
                    new DecimalnumericArray2M
                    {
                        Id = 834987876,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0053099636984868m,

0.731854891945727m,

0.351988672731008m,

0.405537855683236m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 2011771634,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    915400433,
                    new DecimalnumericArray2M
                    {
                        Id = 915400433,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0166545901535174m,

0.206620598222032m,

0.391263159110828m,

0.705434996451676m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.739305905841844m,

0.33953053302698m,

0.85012481430072m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 968118874,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1097674407,
                    new DecimalnumericArray2M
                    {
                        Id = 1097674407,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.213901134654812m,

0.802377216374324m,

0.590198962530489m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1145173047,
                    new DecimalnumericArray2M
                    {
                        Id = 1145173047,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.86169160125173m,

0.665813480687247m,

0.258944008533323m,

0.497954715715701m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.886005133996744m,

0.537694589973166m,

0.948419836595352m,

0.899984538105101m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1782954037,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

}
                        }

                    }
                );

                expected.Add(
                    1158777108,
                    new DecimalnumericArray2M
                    {
                        Id = 1158777108,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.632245436817918m,

0.525081293923471m,

0.740365139715133m,

0.160337973892956m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.236224853235397m,

0.873319493230595m,

0.529715764316108m,

0.644567077449544m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1263865151,
                    new DecimalnumericArray2M
                    {
                        Id = 1263865151,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.428655738354415m,

0.834009933077382m,

0.572922537594729m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0000500911924378178m,

0.113760639302542m,

0.272445018515412m,

0.740383674889009m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1853049896,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

}
                        }

                    }
                );

                expected.Add(
                    1297290090,
                    new DecimalnumericArray2M
                    {
                        Id = 1297290090,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.662994291475258m,

0.335546559217677m,

0.814666136658041m,

0.510016926250202m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1163997611,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

}
                        }

                    }
                );

                expected.Add(
                    1342660566,
                    new DecimalnumericArray2M
                    {
                        Id = 1342660566,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.138063993051759m,

0.0485852827126387m,

0.213228430602675m,

0.167671779856126m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.133409569742517m,

0.897030014921523m,

0.749150043166243m,

0.509100770482221m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1459685240,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

}
                        }

                    }
                );

                expected.Add(
                    1412782945,
                    new DecimalnumericArray2M
                    {
                        Id = 1412782945,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.837051944472662m,

0.100401181186184m,

0.836783829467323m,

0.7257387911882m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 1586099015,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1491840006,
                    new DecimalnumericArray2M
                    {
                        Id = 1491840006,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.108975345294398m,

0.114653006262149m,

0.759880720607427m,

0.729168996559094m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 945324481,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

}
                        }

                    }
                );

                expected.Add(
                    1580017754,
                    new DecimalnumericArray2M
                    {
                        Id = 1580017754,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.287793778501136m,

0.257664742722242m,

0.126441241962921m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1648707232,
                    new DecimalnumericArray2M
                    {
                        Id = 1648707232,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.527847435500984m,

0.173950517284968m,

0.151458256477328m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1773585408,
                    new DecimalnumericArray2M
                    {
                        Id = 1773585408,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.132943536053239m,

0.516561305955052m,

0.990073336993418m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.594596931095681m,

0.539531837190922m,

0.178244580907054m,

0.0773580101660545m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1832017216,
                    new DecimalnumericArray2M
                    {
                        Id = 1832017216,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.454183141990674m,

0.278062957703394m,

0.211389634373654m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.353647017400773m,

0.726861498656907m,

0.429329226106326m,

},

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 92400782,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2032412652,
                    new DecimalnumericArray2M
                    {
                        Id = 2032412652,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.286879202103876m,

0.623037358980244m,

0.670161403049874m,

0.880502436778734m,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2093584601,
                    new DecimalnumericArray2M
                    {
                        Id = 2093584601,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.918010367258993m,

0.0992655951588508m,

0.922247070322136m,

0.314489396402167m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.918775887805232m,

0.895132348268916m,

0.589061467067712m,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2124641163,
                    new DecimalnumericArray2M
                    {
                        Id = 2124641163,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.342458831314668m,

0.487637705678558m,

0.820339870237445m,

},
                        NullableValue = null,

                        ModelInner = new DecimalnumericArray2MI
                        {
                            Id = 624368106,
                            Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

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
COPY public.binary_decimalnumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(DecimalnumericArray2MI),
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

                var expected = new Dictionary<System.Int32,DecimalnumericArray2MI>(15);

                expected.Add(
                    92400782,
                    new DecimalnumericArray2MI
                    {
                        Id = 92400782,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    624368106,
                    new DecimalnumericArray2MI
                    {
                        Id = 624368106,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

}
                    }
                );

                expected.Add(
                    855649252,
                    new DecimalnumericArray2MI
                    {
                        Id = 855649252,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

}
                    }
                );

                expected.Add(
                    945324481,
                    new DecimalnumericArray2MI
                    {
                        Id = 945324481,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

}
                    }
                );

                expected.Add(
                    968118874,
                    new DecimalnumericArray2MI
                    {
                        Id = 968118874,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1163997611,
                    new DecimalnumericArray2MI
                    {
                        Id = 1163997611,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

}
                    }
                );

                expected.Add(
                    1287556208,
                    new DecimalnumericArray2MI
                    {
                        Id = 1287556208,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1325179045,
                    new DecimalnumericArray2MI
                    {
                        Id = 1325179045,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1449931619,
                    new DecimalnumericArray2MI
                    {
                        Id = 1449931619,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

}
                    }
                );

                expected.Add(
                    1459685240,
                    new DecimalnumericArray2MI
                    {
                        Id = 1459685240,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

}
                    }
                );

                expected.Add(
                    1467898803,
                    new DecimalnumericArray2MI
                    {
                        Id = 1467898803,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1586099015,
                    new DecimalnumericArray2MI
                    {
                        Id = 1586099015,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1782954037,
                    new DecimalnumericArray2MI
                    {
                        Id = 1782954037,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

}
                    }
                );

                expected.Add(
                    1853049896,
                    new DecimalnumericArray2MI
                    {
                        Id = 1853049896,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

}
                    }
                );

                expected.Add(
                    2011771634,
                    new DecimalnumericArray2MI
                    {
                        Id = 2011771634,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

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

                var expected = new Dictionary<System.Int32,DecimalnumericArray2MI>(15);

                expected.Add(
                    92400782,
                    new DecimalnumericArray2MI
                    {
                        Id = 92400782,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.63517032783398m,

0.17236919051379m,

0.277474859600405m,

0.581636535997949m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    624368106,
                    new DecimalnumericArray2MI
                    {
                        Id = 624368106,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.900514321455593m,

0.789301221882507m,

0.620694944169254m,

0.697427804356009m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.204279158518639m,

0.18776758960549m,

0.421056528991888m,

0.625989440586509m,

}
                    }
                );

                expected.Add(
                    855649252,
                    new DecimalnumericArray2MI
                    {
                        Id = 855649252,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0310662746926014m,

0.0364997537683661m,

0.919565127388259m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.0954707551483046m,

0.419902157336606m,

0.419185924209743m,

0.706364468987157m,

}
                    }
                );

                expected.Add(
                    945324481,
                    new DecimalnumericArray2MI
                    {
                        Id = 945324481,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.874457511949078m,

0.455108937428237m,

0.488723287142785m,

0.890405251080784m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.718048428875837m,

0.272090267865546m,

0.978156163695877m,

0.635257864087052m,

}
                    }
                );

                expected.Add(
                    968118874,
                    new DecimalnumericArray2MI
                    {
                        Id = 968118874,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.113036089321004m,

0.245736082555622m,

0.315344490023861m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1163997611,
                    new DecimalnumericArray2MI
                    {
                        Id = 1163997611,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.379479191307384m,

0.779056255019149m,

0.774914954411804m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.535623785429044m,

0.468378505217322m,

0.109457037265632m,

0.149448216332031m,

}
                    }
                );

                expected.Add(
                    1287556208,
                    new DecimalnumericArray2MI
                    {
                        Id = 1287556208,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.536493423221195m,

0.626911134974506m,

0.738917920826963m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1325179045,
                    new DecimalnumericArray2MI
                    {
                        Id = 1325179045,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.541332637444254m,

0.145955258772197m,

0.0955614943138825m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1449931619,
                    new DecimalnumericArray2MI
                    {
                        Id = 1449931619,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.27121423590871m,

0.87791945938157m,

0.94736409886689m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.413908852039148m,

0.143750257137892m,

0.92734881403448m,

}
                    }
                );

                expected.Add(
                    1459685240,
                    new DecimalnumericArray2MI
                    {
                        Id = 1459685240,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.619005040429584m,

0.170830696353701m,

0.792800651342257m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.954906113694426m,

0.876172188775988m,

0.431178301296411m,

0.408236796974565m,

}
                    }
                );

                expected.Add(
                    1467898803,
                    new DecimalnumericArray2MI
                    {
                        Id = 1467898803,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.727991282381723m,

0.708468951046211m,

0.174727683729743m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1586099015,
                    new DecimalnumericArray2MI
                    {
                        Id = 1586099015,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.561037756532718m,

0.626748639378797m,

0.583028163365626m,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1782954037,
                    new DecimalnumericArray2MI
                    {
                        Id = 1782954037,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.826512321316611m,

0.493319963504507m,

0.0773908282237566m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.751855950690568m,

0.922207028535492m,

0.816763781674599m,

}
                    }
                );

                expected.Add(
                    1853049896,
                    new DecimalnumericArray2MI
                    {
                        Id = 1853049896,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(4)
{
0.279092816143626m,

0.537397791151456m,

0.0219807132448854m,

0.732652711086869m,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.0725741990618045m,

0.44999859734881m,

0.859785584609196m,

}
                    }
                );

                expected.Add(
                    2011771634,
                    new DecimalnumericArray2MI
                    {
                        Id = 2011771634,
                        Value = 
new System.Collections.Generic.List<System.Decimal>(3)
{
0.75016109577094m,

0.183188996871749m,

0.34676550963732m,

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

