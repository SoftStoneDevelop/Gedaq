

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
    internal partial interface IInt64ArraybigintArray
    {
    }
    
    internal partial class Int64ArraybigintArray : IInt64ArraybigintArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            asPartInterface: typeof(IInt64ArraybigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1mi(
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
            queryMapType: typeof(Int64bigintArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, 141740444, 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

}, 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModelInner(connection, 1363757148, 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, 234683638, 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

}, 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelInnerAsync(connection, 897859832, 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

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

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, 1790046146, 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

}, null);
                Assert.That(id, Is.EqualTo(1790046146));

                id =  ((IInt64ArraybigintArray)this).InsertModelInnerReturning(connection, 1572323312, 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

}, 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

});
                Assert.That(id, Is.EqualTo(1572323312));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 1705781836, 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

}, null);
                Assert.That(id, Is.EqualTo(1705781836));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 1526878055, 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

}, 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

});
                Assert.That(id, Is.EqualTo(1526878055));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 692066564, 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

}, null);
                Assert.That(id, Is.EqualTo(692066564));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 1721789971, 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

}, 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

});
                Assert.That(id, Is.EqualTo(1721789971));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 594590365, 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

}, 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

});
                Assert.That(id, Is.EqualTo(594590365));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 1215257793, 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

}, null);
                Assert.That(id, Is.EqualTo(1215257793));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 158658366, 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

}, 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

});
                Assert.That(id, Is.EqualTo(158658366));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 1203935812, 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

}, null);
                Assert.That(id, Is.EqualTo(1203935812));

                id = await ((IInt64ArraybigintArray)this).InsertModelInnerReturningAsync(connection, 595838883, 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

}, 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

});
                Assert.That(id, Is.EqualTo(595838883));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
            asPartInterface: typeof(IInt64ArraybigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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

                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, 2125863590, 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

}, 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ArraybigintArray)this).InsertModel(connection, 73205771, 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

}, null, 141740444);
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

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, 1508257348, 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ArraybigintArray)this).InsertModelAsync(connection, 640339449, 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

}, null, 1363757148);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;

                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, 2035739909, 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable =  ((IInt64ArraybigintArray)this).ScalarInsertModelReturning(connection, 623728289, 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

}, 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

}, 234683638);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

}));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int64[] nullable = null;

                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, 1794296322, 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((IInt64ArraybigintArray)this).ScalarInsertModelReturningAsync(connection, 1982777865, 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

}, 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

}, 897859832);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

}));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray1m(
	id,
    value,
    nullablevalue,
    int64bigintarray1mi_id
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
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Int64bigintArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int64[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray1mi_id", 
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
                List<Int64bigintArray1M> models = null;
                Int64bigintArray1M model = null;

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, 520992644, 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

}, 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, 97777545, 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

}, 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

}, 1790046146).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(97777545));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1790046146));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, 1451994330, 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt64ArraybigintArray)this).InsertModelReturning(connection, 1729143426, 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

}, null, 1572323312).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray1M> models = null;
                Int64bigintArray1M model = null;

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1035784739, 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1889999231, 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

}, null, 1705781836).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 496649949, 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

}, 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 677579965, 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

}, 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

}, 1526878055).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1949564878, 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

}, 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 322575656, 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

}, 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

}, 692066564).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1525626791, 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 2085327961, 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

}, null, 1721789971).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1531236092, 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1079517940, 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

}, null, 594590365).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1532616346, 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 73717351, 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

}, 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

}, 1215257793).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(73717351));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1215257793));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 778075604, 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1521109673, 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

}, 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

}, 158658366).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1402706262, 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1345865591, 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

}, null, 1203935812).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 1384755802, 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

}, 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ArraybigintArray)this).InsertModelReturningAsync(connection, 961618653, 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

}, null, 595838883).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Int64bigintArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)
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
                var models =  ((IInt64ArraybigintArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(73205771));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(141740444));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(73717351));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1215257793));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

};
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
                Assert.That(model.Id, Is.EqualTo(97777545));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1790046146));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

};
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
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
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
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
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
                Assert.That(model.Id, Is.EqualTo(623728289));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(234683638));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(640339449));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363757148));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1508257348));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
                var models = await ((IInt64ArraybigintArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(73205771));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(141740444));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(73717351));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1215257793));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

};
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
                Assert.That(model.Id, Is.EqualTo(97777545));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1790046146));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

};
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
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
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
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
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
                Assert.That(model.Id, Is.EqualTo(623728289));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(234683638));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(640339449));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363757148));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1508257348));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
FROM public.int64bigintarray1m m
LEFT JOIN public.int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Int64bigintArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ArraybigintArray)
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
                var models =  ((IInt64ArraybigintArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(73205771));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(141740444));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(73717351));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1215257793));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

};
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
                Assert.That(model.Id, Is.EqualTo(97777545));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1790046146));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

};
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
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
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
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
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
                Assert.That(model.Id, Is.EqualTo(623728289));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(234683638));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(640339449));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363757148));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1508257348));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
                var models = await ((IInt64ArraybigintArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(73205771));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(141740444));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(73717351));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1215257793));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

};
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
                Assert.That(model.Id, Is.EqualTo(97777545));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1790046146));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

};
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
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
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
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
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
                Assert.That(model.Id, Is.EqualTo(623728289));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(234683638));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(640339449));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363757148));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1508257348));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
                 using var cmd =  ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 1982777865);
                var models =  ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(3));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
                await using var cmd = await ((IInt64ArraybigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ArraybigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 97777545);
                var models = await ((IInt64ArraybigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(27));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
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
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
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
                Assert.That(model.Id, Is.EqualTo(623728289));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(234683638));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(640339449));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363757148));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1508257348));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
            asPartInterface: typeof(IInt64ArraybigintArray)
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
                 foreach(var batchResult in ((IInt64ArraybigintArray)this).DbConnectionSelectModelBatch(connection, 1729143426, 1982777865))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(7));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
                        Assert.That(models, Has.Count.EqualTo(3));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
                await foreach(var batchResult in ((IInt64ArraybigintArray)this).DbConnectionSelectModelBatchAsync(connection, 1521109673, 1035784739))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
                        Assert.That(models, Has.Count.EqualTo(18));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1508257348));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
COPY public.binary_int64bigintarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
FROM public.binary_int64bigintarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
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

                var importCollection = new List<Int64bigintArray1MI>(7);

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 141740444,
                    Value = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

},
                    NullableValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 158658366,
                    Value = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

},
                    NullableValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 234683638,
                    Value = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

},
                    NullableValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 594590365,
                    Value = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

},
                    NullableValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 595838883,
                    Value = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

},
                    NullableValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 692066564,
                    Value = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 897859832,
                    Value = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(141740444));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(158658366));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(234683638));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(594590365));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(595838883));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(692066564));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(897859832));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                new Int64bigintArray1MI
                {
                    Id = 1203935812,
                    Value = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 1215257793,
                    Value = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 1363757148,
                    Value = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 1526878055,
                    Value = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

},
                    NullableValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 1572323312,
                    Value = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

},
                    NullableValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 1705781836,
                    Value = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 1721789971,
                    Value = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

},
                    NullableValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

}
                });

                importCollection.Add(
                new Int64bigintArray1MI
                {
                    Id = 1790046146,
                    Value = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(141740444));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(158658366));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(234683638));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(594590365));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(595838883));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(692066564));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(897859832));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(1203935812));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1215257793));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

};
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
                Assert.That(model.Id, Is.EqualTo(1363757148));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(1526878055));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(1572323312));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1705781836));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1721789971));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(1790046146));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

};
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
COPY public.binary_int64bigintarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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
FROM public.binary_int64bigintarray1m m
LEFT JOIN public.binary_int64bigintarray1mi mi ON mi.id = m.int64bigintarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Int64bigintArray1M),
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

                var importCollection = new List<Int64bigintArray1M>(15);

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 73205771,
                    Value = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 141740444
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 73717351,
                    Value = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

},
                    NullableValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

},

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1215257793
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 97777545,
                    Value = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

},
                    NullableValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

},

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1790046146
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 322575656,
                    Value = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

},
                    NullableValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

},

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 692066564
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 496649949,
                    Value = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

},
                    NullableValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 520992644,
                    Value = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

},
                    NullableValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 623728289,
                    Value = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

},
                    NullableValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

},

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 234683638
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 640339449,
                    Value = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1363757148
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 677579965,
                    Value = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

},
                    NullableValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

},

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1526878055
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 778075604,
                    Value = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 961618653,
                    Value = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 595838883
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1035784739,
                    Value = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1079517940,
                    Value = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 594590365
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1345865591,
                    Value = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1203935812
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1384755802,
                    Value = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

},
                    NullableValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(73205771));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(141740444));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(73717351));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1215257793));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

};
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
                Assert.That(model.Id, Is.EqualTo(97777545));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1790046146));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

};
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
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
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
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
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
                Assert.That(model.Id, Is.EqualTo(623728289));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(234683638));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(640339449));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363757148));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                new Int64bigintArray1M
                {
                    Id = 1402706262,
                    Value = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1451994330,
                    Value = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1508257348,
                    Value = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1521109673,
                    Value = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

},
                    NullableValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

},

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 158658366
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1525626791,
                    Value = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1531236092,
                    Value = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1532616346,
                    Value = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1729143426,
                    Value = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1572323312
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1794296322,
                    Value = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1889999231,
                    Value = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1705781836
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1949564878,
                    Value = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

},
                    NullableValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 1982777865,
                    Value = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

},
                    NullableValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

},

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 897859832
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 2035739909,
                    Value = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 2085327961,
                    Value = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray1MI 
                    {
                        Id = 1721789971
                    }

                });

                importCollection.Add(
                new Int64bigintArray1M
                {
                    Id = 2125863590,
                    Value = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

},
                    NullableValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

},

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(73205771));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(141740444));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

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
                Assert.That(model.Id, Is.EqualTo(73717351));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1215257793));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

};
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
                Assert.That(model.Id, Is.EqualTo(97777545));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1790046146));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

};
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
                Assert.That(model.Id, Is.EqualTo(322575656));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(692066564));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

};
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
                Assert.That(model.Id, Is.EqualTo(496649949));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

};
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
                Assert.That(model.Id, Is.EqualTo(520992644));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

};
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
                Assert.That(model.Id, Is.EqualTo(623728289));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(234683638));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

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
                Assert.That(model.Id, Is.EqualTo(640339449));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1363757148));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

};
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
                Assert.That(model.Id, Is.EqualTo(677579965));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1526878055));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

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
                Assert.That(model.Id, Is.EqualTo(778075604));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(961618653));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(595838883));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

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
                Assert.That(model.Id, Is.EqualTo(1035784739));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1079517940));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(594590365));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

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
                Assert.That(model.Id, Is.EqualTo(1345865591));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1203935812));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

};
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
                Assert.That(model.Id, Is.EqualTo(1384755802));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

};
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
                Assert.That(model.Id, Is.EqualTo(1402706262));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1451994330));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1508257348));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1521109673));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(158658366));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

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
                Assert.That(model.Id, Is.EqualTo(1525626791));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1531236092));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1532616346));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1729143426));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1572323312));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

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
                Assert.That(model.Id, Is.EqualTo(1794296322));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1889999231));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1705781836));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

};
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
                Assert.That(model.Id, Is.EqualTo(1949564878));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

};
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
                Assert.That(model.Id, Is.EqualTo(1982777865));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(897859832));

                {
                    var expectEnumerValue = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

};
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
                Assert.That(model.Id, Is.EqualTo(2035739909));
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2085327961));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1721789971));

                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

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
                Assert.That(model.Id, Is.EqualTo(2125863590));
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

};
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
COPY public.binary_int64bigintarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Int64bigintArray1M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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

                var expected = new Dictionary<System.Int32,Int64bigintArray1M>(30);

                expected.Add(
                    73205771,
                    new Int64bigintArray1M
                    {
                        Id = 73205771,
                        Value = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 141740444,
                            Value = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

},
                            NullableValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

}
                        }

                    }
                );

                expected.Add(
                    73717351,
                    new Int64bigintArray1M
                    {
                        Id = 73717351,
                        Value = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

},
                        NullableValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1215257793,
                            Value = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    97777545,
                    new Int64bigintArray1M
                    {
                        Id = 97777545,
                        Value = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

},
                        NullableValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1790046146,
                            Value = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    322575656,
                    new Int64bigintArray1M
                    {
                        Id = 322575656,
                        Value = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

},
                        NullableValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 692066564,
                            Value = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    496649949,
                    new Int64bigintArray1M
                    {
                        Id = 496649949,
                        Value = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

},
                        NullableValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    520992644,
                    new Int64bigintArray1M
                    {
                        Id = 520992644,
                        Value = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

},
                        NullableValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    623728289,
                    new Int64bigintArray1M
                    {
                        Id = 623728289,
                        Value = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

},
                        NullableValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 234683638,
                            Value = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

},
                            NullableValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

}
                        }

                    }
                );

                expected.Add(
                    640339449,
                    new Int64bigintArray1M
                    {
                        Id = 640339449,
                        Value = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1363757148,
                            Value = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    677579965,
                    new Int64bigintArray1M
                    {
                        Id = 677579965,
                        Value = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

},
                        NullableValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1526878055,
                            Value = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

},
                            NullableValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

}
                        }

                    }
                );

                expected.Add(
                    778075604,
                    new Int64bigintArray1M
                    {
                        Id = 778075604,
                        Value = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    961618653,
                    new Int64bigintArray1M
                    {
                        Id = 961618653,
                        Value = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 595838883,
                            Value = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

},
                            NullableValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

}
                        }

                    }
                );

                expected.Add(
                    1035784739,
                    new Int64bigintArray1M
                    {
                        Id = 1035784739,
                        Value = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1079517940,
                    new Int64bigintArray1M
                    {
                        Id = 1079517940,
                        Value = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 594590365,
                            Value = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

},
                            NullableValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

}
                        }

                    }
                );

                expected.Add(
                    1345865591,
                    new Int64bigintArray1M
                    {
                        Id = 1345865591,
                        Value = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1203935812,
                            Value = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1384755802,
                    new Int64bigintArray1M
                    {
                        Id = 1384755802,
                        Value = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

},
                        NullableValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1402706262,
                    new Int64bigintArray1M
                    {
                        Id = 1402706262,
                        Value = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1451994330,
                    new Int64bigintArray1M
                    {
                        Id = 1451994330,
                        Value = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1508257348,
                    new Int64bigintArray1M
                    {
                        Id = 1508257348,
                        Value = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1521109673,
                    new Int64bigintArray1M
                    {
                        Id = 1521109673,
                        Value = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

},
                        NullableValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 158658366,
                            Value = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

},
                            NullableValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

}
                        }

                    }
                );

                expected.Add(
                    1525626791,
                    new Int64bigintArray1M
                    {
                        Id = 1525626791,
                        Value = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1531236092,
                    new Int64bigintArray1M
                    {
                        Id = 1531236092,
                        Value = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1532616346,
                    new Int64bigintArray1M
                    {
                        Id = 1532616346,
                        Value = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1729143426,
                    new Int64bigintArray1M
                    {
                        Id = 1729143426,
                        Value = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1572323312,
                            Value = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

},
                            NullableValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

}
                        }

                    }
                );

                expected.Add(
                    1794296322,
                    new Int64bigintArray1M
                    {
                        Id = 1794296322,
                        Value = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1889999231,
                    new Int64bigintArray1M
                    {
                        Id = 1889999231,
                        Value = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1705781836,
                            Value = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1949564878,
                    new Int64bigintArray1M
                    {
                        Id = 1949564878,
                        Value = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

},
                        NullableValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1982777865,
                    new Int64bigintArray1M
                    {
                        Id = 1982777865,
                        Value = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

},
                        NullableValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 897859832,
                            Value = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2035739909,
                    new Int64bigintArray1M
                    {
                        Id = 2035739909,
                        Value = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2085327961,
                    new Int64bigintArray1M
                    {
                        Id = 2085327961,
                        Value = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1721789971,
                            Value = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

},
                            NullableValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

}
                        }

                    }
                );

                expected.Add(
                    2125863590,
                    new Int64bigintArray1M
                    {
                        Id = 2125863590,
                        Value = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

},
                        NullableValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
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

                var expected = new Dictionary<System.Int32,Int64bigintArray1M>(30);

                expected.Add(
                    73205771,
                    new Int64bigintArray1M
                    {
                        Id = 73205771,
                        Value = 
new System.Int64[4]
{
517999408754498995L,

7488932698532292878L,

4883520200905569334L,

5979405748937457710L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 141740444,
                            Value = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

},
                            NullableValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

}
                        }

                    }
                );

                expected.Add(
                    73717351,
                    new Int64bigintArray1M
                    {
                        Id = 73717351,
                        Value = 
new System.Int64[3]
{
7183881797147900227L,

6830871163321157393L,

2044566596220856335L,

},
                        NullableValue = 
new System.Int64[3]
{
5348819222945131458L,

766273684447148767L,

6215440169171834537L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1215257793,
                            Value = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    97777545,
                    new Int64bigintArray1M
                    {
                        Id = 97777545,
                        Value = 
new System.Int64[3]
{
5172505313644219546L,

1711755367285375131L,

3038096767018036287L,

},
                        NullableValue = 
new System.Int64[3]
{
4590817164303069637L,

5690672308918771612L,

7348348599790806440L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1790046146,
                            Value = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    322575656,
                    new Int64bigintArray1M
                    {
                        Id = 322575656,
                        Value = 
new System.Int64[4]
{
1735951002503673645L,

5133827430136561995L,

783477359371770473L,

3135167167542446200L,

},
                        NullableValue = 
new System.Int64[4]
{
3580754581535202286L,

2559049872900205945L,

2009873167323429619L,

3511009467284352627L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 692066564,
                            Value = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    496649949,
                    new Int64bigintArray1M
                    {
                        Id = 496649949,
                        Value = 
new System.Int64[3]
{
5303688120654061509L,

3576079769471280742L,

8150089801194620153L,

},
                        NullableValue = 
new System.Int64[4]
{
8911175279790734185L,

5983702695725388280L,

4343655966521546458L,

8502281054988342338L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    520992644,
                    new Int64bigintArray1M
                    {
                        Id = 520992644,
                        Value = 
new System.Int64[3]
{
6995025754665150775L,

6516889027783534585L,

5924140070651760469L,

},
                        NullableValue = 
new System.Int64[4]
{
1838029933093009559L,

7849391003433874693L,

4953396006694576069L,

5538910139077259074L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    623728289,
                    new Int64bigintArray1M
                    {
                        Id = 623728289,
                        Value = 
new System.Int64[3]
{
4566544744077093065L,

9141322146139970959L,

7269753580512428317L,

},
                        NullableValue = 
new System.Int64[3]
{
5182826057172962539L,

6443995829359898405L,

8419266285348330110L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 234683638,
                            Value = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

},
                            NullableValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

}
                        }

                    }
                );

                expected.Add(
                    640339449,
                    new Int64bigintArray1M
                    {
                        Id = 640339449,
                        Value = 
new System.Int64[4]
{
2878805189579703109L,

1796106256426926990L,

1125910965752085940L,

8205617827912686293L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1363757148,
                            Value = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    677579965,
                    new Int64bigintArray1M
                    {
                        Id = 677579965,
                        Value = 
new System.Int64[4]
{
5203475181770113263L,

3861333526620387049L,

8902579404915715010L,

5025734056977348287L,

},
                        NullableValue = 
new System.Int64[4]
{
4666355355459687796L,

4960265762457052666L,

1308911481640706660L,

2221549364267336890L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1526878055,
                            Value = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

},
                            NullableValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

}
                        }

                    }
                );

                expected.Add(
                    778075604,
                    new Int64bigintArray1M
                    {
                        Id = 778075604,
                        Value = 
new System.Int64[3]
{
6360169572063882280L,

1700127305838764035L,

737254202818217008L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    961618653,
                    new Int64bigintArray1M
                    {
                        Id = 961618653,
                        Value = 
new System.Int64[4]
{
5982609908360054026L,

3632112841232195382L,

4484814809923617431L,

8321953953375364725L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 595838883,
                            Value = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

},
                            NullableValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

}
                        }

                    }
                );

                expected.Add(
                    1035784739,
                    new Int64bigintArray1M
                    {
                        Id = 1035784739,
                        Value = 
new System.Int64[4]
{
2482450797359751357L,

419651731245017702L,

3698257019335085029L,

4481174777983846126L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1079517940,
                    new Int64bigintArray1M
                    {
                        Id = 1079517940,
                        Value = 
new System.Int64[4]
{
4047039170226701311L,

6096939671390894832L,

8984533278949907573L,

7341262181752450389L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 594590365,
                            Value = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

},
                            NullableValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

}
                        }

                    }
                );

                expected.Add(
                    1345865591,
                    new Int64bigintArray1M
                    {
                        Id = 1345865591,
                        Value = 
new System.Int64[4]
{
5131336415191139697L,

2731438581690392377L,

789861172984376177L,

5810121899368635445L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1203935812,
                            Value = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1384755802,
                    new Int64bigintArray1M
                    {
                        Id = 1384755802,
                        Value = 
new System.Int64[3]
{
3015267747031511450L,

2514491766469307436L,

5700770728629552771L,

},
                        NullableValue = 
new System.Int64[4]
{
4410695982994400873L,

4786451548786038074L,

2593692376951718279L,

9188314536437663390L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1402706262,
                    new Int64bigintArray1M
                    {
                        Id = 1402706262,
                        Value = 
new System.Int64[3]
{
8633736601771219817L,

4377609916299543026L,

6682167443094875608L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1451994330,
                    new Int64bigintArray1M
                    {
                        Id = 1451994330,
                        Value = 
new System.Int64[3]
{
2564786279392878343L,

128951542006887831L,

5338334470785200983L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1508257348,
                    new Int64bigintArray1M
                    {
                        Id = 1508257348,
                        Value = 
new System.Int64[3]
{
4137015364251531944L,

6560726182292290796L,

6491234904954071295L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1521109673,
                    new Int64bigintArray1M
                    {
                        Id = 1521109673,
                        Value = 
new System.Int64[3]
{
5691345830232708777L,

9062094935915872240L,

6076259468365479039L,

},
                        NullableValue = 
new System.Int64[3]
{
7185205815150403081L,

3221713971000771015L,

339628181008000313L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 158658366,
                            Value = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

},
                            NullableValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

}
                        }

                    }
                );

                expected.Add(
                    1525626791,
                    new Int64bigintArray1M
                    {
                        Id = 1525626791,
                        Value = 
new System.Int64[4]
{
4782968842614531161L,

419296505582440158L,

2763768575115995914L,

2249039790956754576L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1531236092,
                    new Int64bigintArray1M
                    {
                        Id = 1531236092,
                        Value = 
new System.Int64[3]
{
3258743175269710299L,

4862603256795785986L,

5198838139644374790L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1532616346,
                    new Int64bigintArray1M
                    {
                        Id = 1532616346,
                        Value = 
new System.Int64[3]
{
8069494509669780144L,

737717920523150460L,

369256917382261467L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1729143426,
                    new Int64bigintArray1M
                    {
                        Id = 1729143426,
                        Value = 
new System.Int64[3]
{
7297802676657210765L,

8961126171963664609L,

7090508747800641693L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1572323312,
                            Value = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

},
                            NullableValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

}
                        }

                    }
                );

                expected.Add(
                    1794296322,
                    new Int64bigintArray1M
                    {
                        Id = 1794296322,
                        Value = 
new System.Int64[3]
{
1494756188566152770L,

6258571571047130505L,

8965956865362395381L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1889999231,
                    new Int64bigintArray1M
                    {
                        Id = 1889999231,
                        Value = 
new System.Int64[4]
{
1206253777053980398L,

1710499613432399000L,

5082609813423782083L,

4592133700971856057L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1705781836,
                            Value = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1949564878,
                    new Int64bigintArray1M
                    {
                        Id = 1949564878,
                        Value = 
new System.Int64[3]
{
4955105770486520473L,

8845754829138120404L,

1983514200944061524L,

},
                        NullableValue = 
new System.Int64[3]
{
3745697575492756027L,

1158450723909009110L,

3503124005302694236L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1982777865,
                    new Int64bigintArray1M
                    {
                        Id = 1982777865,
                        Value = 
new System.Int64[4]
{
835779200017527694L,

8486980146439961314L,

1272814721704208374L,

3243016467277698032L,

},
                        NullableValue = 
new System.Int64[3]
{
1017817452608048417L,

5394873976005365806L,

7196722890250151562L,

},

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 897859832,
                            Value = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2035739909,
                    new Int64bigintArray1M
                    {
                        Id = 2035739909,
                        Value = 
new System.Int64[3]
{
6487022526021896545L,

6263461369528828995L,

2894655658099627546L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2085327961,
                    new Int64bigintArray1M
                    {
                        Id = 2085327961,
                        Value = 
new System.Int64[4]
{
9146926081172713156L,

137300150407158927L,

7656013720522393869L,

8091522628908936215L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray1MI
                        {
                            Id = 1721789971,
                            Value = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

},
                            NullableValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

}
                        }

                    }
                );

                expected.Add(
                    2125863590,
                    new Int64bigintArray1M
                    {
                        Id = 2125863590,
                        Value = 
new System.Int64[4]
{
7109419074361546468L,

3063301368162210456L,

3020371278647558146L,

6093206529573868863L,

},
                        NullableValue = 
new System.Int64[4]
{
6549459073250977375L,

4504953578216200450L,

2245002408306811089L,

7833040261008014098L,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Int64[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Int64bigintArray1MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647),
                (NpgsqlTypes.NpgsqlDbType)(-2147483647)
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

                var expected = new Dictionary<System.Int32,Int64bigintArray1MI>(15);

                expected.Add(
                    141740444,
                    new Int64bigintArray1MI
                    {
                        Id = 141740444,
                        Value = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

},
                        NullableValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

}
                    }
                );

                expected.Add(
                    158658366,
                    new Int64bigintArray1MI
                    {
                        Id = 158658366,
                        Value = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

},
                        NullableValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

}
                    }
                );

                expected.Add(
                    234683638,
                    new Int64bigintArray1MI
                    {
                        Id = 234683638,
                        Value = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

},
                        NullableValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

}
                    }
                );

                expected.Add(
                    594590365,
                    new Int64bigintArray1MI
                    {
                        Id = 594590365,
                        Value = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

},
                        NullableValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

}
                    }
                );

                expected.Add(
                    595838883,
                    new Int64bigintArray1MI
                    {
                        Id = 595838883,
                        Value = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

},
                        NullableValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

}
                    }
                );

                expected.Add(
                    692066564,
                    new Int64bigintArray1MI
                    {
                        Id = 692066564,
                        Value = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    897859832,
                    new Int64bigintArray1MI
                    {
                        Id = 897859832,
                        Value = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1203935812,
                    new Int64bigintArray1MI
                    {
                        Id = 1203935812,
                        Value = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1215257793,
                    new Int64bigintArray1MI
                    {
                        Id = 1215257793,
                        Value = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1363757148,
                    new Int64bigintArray1MI
                    {
                        Id = 1363757148,
                        Value = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1526878055,
                    new Int64bigintArray1MI
                    {
                        Id = 1526878055,
                        Value = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

},
                        NullableValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

}
                    }
                );

                expected.Add(
                    1572323312,
                    new Int64bigintArray1MI
                    {
                        Id = 1572323312,
                        Value = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

},
                        NullableValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

}
                    }
                );

                expected.Add(
                    1705781836,
                    new Int64bigintArray1MI
                    {
                        Id = 1705781836,
                        Value = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1721789971,
                    new Int64bigintArray1MI
                    {
                        Id = 1721789971,
                        Value = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

},
                        NullableValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

}
                    }
                );

                expected.Add(
                    1790046146,
                    new Int64bigintArray1MI
                    {
                        Id = 1790046146,
                        Value = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

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

                var expected = new Dictionary<System.Int32,Int64bigintArray1MI>(15);

                expected.Add(
                    141740444,
                    new Int64bigintArray1MI
                    {
                        Id = 141740444,
                        Value = 
new System.Int64[4]
{
2188213856121384983L,

1678240601093529255L,

6937161461059350201L,

7272225790159987420L,

},
                        NullableValue = 
new System.Int64[3]
{
3912681570860184444L,

2108339084241243804L,

1477517202571343665L,

}
                    }
                );

                expected.Add(
                    158658366,
                    new Int64bigintArray1MI
                    {
                        Id = 158658366,
                        Value = 
new System.Int64[3]
{
5866926087583228010L,

4450899027067359140L,

457228625063821522L,

},
                        NullableValue = 
new System.Int64[4]
{
6298714398574202956L,

874207077570796104L,

5955569720735605739L,

1224804307447432431L,

}
                    }
                );

                expected.Add(
                    234683638,
                    new Int64bigintArray1MI
                    {
                        Id = 234683638,
                        Value = 
new System.Int64[3]
{
8967046497318276380L,

7253258858370827231L,

7543135173276433957L,

},
                        NullableValue = 
new System.Int64[3]
{
9197945362990847912L,

573248459010997197L,

3736476259362829446L,

}
                    }
                );

                expected.Add(
                    594590365,
                    new Int64bigintArray1MI
                    {
                        Id = 594590365,
                        Value = 
new System.Int64[3]
{
2207265072585623978L,

2126205184744282278L,

5162482287546299681L,

},
                        NullableValue = 
new System.Int64[3]
{
2172037644396692878L,

741843562376579642L,

5847878482304981440L,

}
                    }
                );

                expected.Add(
                    595838883,
                    new Int64bigintArray1MI
                    {
                        Id = 595838883,
                        Value = 
new System.Int64[3]
{
6361897924385432704L,

1438540111429491247L,

4824288770835956899L,

},
                        NullableValue = 
new System.Int64[3]
{
3462542145350717911L,

8007377358999758838L,

2563459809360161541L,

}
                    }
                );

                expected.Add(
                    692066564,
                    new Int64bigintArray1MI
                    {
                        Id = 692066564,
                        Value = 
new System.Int64[3]
{
8044607908961708786L,

3352045039237824352L,

3074320814547895291L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    897859832,
                    new Int64bigintArray1MI
                    {
                        Id = 897859832,
                        Value = 
new System.Int64[4]
{
3138892220211040945L,

2343405445957619636L,

3418444515324093554L,

8002352749963276170L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1203935812,
                    new Int64bigintArray1MI
                    {
                        Id = 1203935812,
                        Value = 
new System.Int64[3]
{
6138372566786271975L,

6467795193978203349L,

5270548583338533334L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1215257793,
                    new Int64bigintArray1MI
                    {
                        Id = 1215257793,
                        Value = 
new System.Int64[4]
{
1361746670861543740L,

84030533171801482L,

7266918365628065397L,

3387583692660271273L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1363757148,
                    new Int64bigintArray1MI
                    {
                        Id = 1363757148,
                        Value = 
new System.Int64[3]
{
4249440711999549746L,

564100528140787487L,

879393593156267100L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1526878055,
                    new Int64bigintArray1MI
                    {
                        Id = 1526878055,
                        Value = 
new System.Int64[3]
{
5053374721279096307L,

5372763372888106244L,

535583991242869206L,

},
                        NullableValue = 
new System.Int64[4]
{
3341964127319759485L,

5548699902213074459L,

538042773678183336L,

1346896402145278197L,

}
                    }
                );

                expected.Add(
                    1572323312,
                    new Int64bigintArray1MI
                    {
                        Id = 1572323312,
                        Value = 
new System.Int64[3]
{
8356674568904435296L,

6235141352803885517L,

2120430244885136462L,

},
                        NullableValue = 
new System.Int64[4]
{
1959189539713970413L,

5748400949843568588L,

8723571735159762198L,

4969910521805990042L,

}
                    }
                );

                expected.Add(
                    1705781836,
                    new Int64bigintArray1MI
                    {
                        Id = 1705781836,
                        Value = 
new System.Int64[3]
{
2489281808159453339L,

8391015230467035839L,

6175416201736841355L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1721789971,
                    new Int64bigintArray1MI
                    {
                        Id = 1721789971,
                        Value = 
new System.Int64[3]
{
3668412518553016687L,

1774456008697310588L,

6257067207148198407L,

},
                        NullableValue = 
new System.Int64[3]
{
3958567750383564534L,

2339657245658215680L,

8886539628557043490L,

}
                    }
                );

                expected.Add(
                    1790046146,
                    new Int64bigintArray1MI
                    {
                        Id = 1790046146,
                        Value = 
new System.Int64[3]
{
1433795497098972720L,

552889005071179076L,

929672823812726640L,

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

