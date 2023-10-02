

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
    internal partial interface IInt64ListbigintArray
    {
    }
    
    internal partial class Int64ListbigintArray : IInt64ListbigintArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2mi(
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
            asPartInterface: typeof(IInt64ListbigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
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
INSERT INTO public.int64bigintarray2mi(
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
            queryMapType: typeof(Int64bigintArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
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

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, 1068735979, 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintArray)this).InsertModelInner(connection, 1717110302, 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, 1089314455, 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintArray)this).InsertModelInnerAsync(connection, 1120633593, 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, 1124116964, 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

});
                Assert.That(id, Is.EqualTo(1124116964));

                id =  ((IInt64ListbigintArray)this).InsertModelInnerReturning(connection, 1588648923, 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

});
                Assert.That(id, Is.EqualTo(1588648923));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 315849548, 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

}, null);
                Assert.That(id, Is.EqualTo(315849548));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 657772507, 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

});
                Assert.That(id, Is.EqualTo(657772507));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 113727466, 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

});
                Assert.That(id, Is.EqualTo(113727466));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 118270711, 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

}, null);
                Assert.That(id, Is.EqualTo(118270711));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 2054626758, 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

}, null);
                Assert.That(id, Is.EqualTo(2054626758));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 1075285206, 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

});
                Assert.That(id, Is.EqualTo(1075285206));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 164516609, 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

}, null);
                Assert.That(id, Is.EqualTo(164516609));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 1431435208, 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

}, null);
                Assert.That(id, Is.EqualTo(1431435208));

                id = await ((IInt64ListbigintArray)this).InsertModelInnerReturningAsync(connection, 694960872, 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

}, null);
                Assert.That(id, Is.EqualTo(694960872));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
            asPartInterface: typeof(IInt64ListbigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
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

                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, 919680782, 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IInt64ListbigintArray)this).InsertModel(connection, 502858657, 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

}, 1068735979);
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

                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, 1326167488, 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IInt64ListbigintArray)this).InsertModelAsync(connection, 315687868, 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

}, 1717110302);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.int64bigintarray2m(
	id,
    value,
    nullablevalue,
    int64bigintarray2mi_id
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
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(Int64bigintArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Int64>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483647)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "int64bigintarray2mi_id", 
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
                List<Int64bigintArray2M> models = null;
                Int64bigintArray2M model = null;

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, 279780229, 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, 176635402, 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

}, null, 1089314455).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, 1606309445, 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IInt64ListbigintArray)this).InsertModelReturning(connection, 776058429, 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

}, 1120633593).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<Int64bigintArray2M> models = null;
                Int64bigintArray2M model = null;

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 66234440, 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(66234440));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 461697494, 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

}, 1124116964).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 1107214713, 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 115453654, 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

}, null, 1588648923).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 972727078, 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 2123850416, 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

}, 315849548).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 178932640, 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 827877573, 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

}, null, 657772507).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 25706917, 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25706917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 423165133, 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

}, 113727466).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 719038842, 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 630115869, 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

}, null, 118270711).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 1716292140, 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 927274065, 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

}, 2054626758).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 851629924, 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 667655934, 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

}, null, 1075285206).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 2139664898, 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 534808018, 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

}, 164516609).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 675723701, 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 1337707405, 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

}, 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

}, 1431435208).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 2139501794, 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

}, 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IInt64ListbigintArray)this).InsertModelReturningAsync(connection, 773112634, 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

}, null, 694960872).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(Int64bigintArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)
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
                var models =  ((IInt64ListbigintArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25706917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(66234440));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IInt64ListbigintArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25706917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(66234440));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
FROM public.int64bigintarray2m m
LEFT JOIN public.int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(Int64bigintArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IInt64ListbigintArray)
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
                var models =  ((IInt64ListbigintArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25706917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(66234440));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                var models = await ((IInt64ListbigintArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25706917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(66234440));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                 using var cmd =  ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 176635402);
                var models =  ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(26));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await using var cmd = await ((IInt64ListbigintArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IInt64ListbigintArray)this).SetDbConnectionSelectModelParametrs(cmd, 851629924);
                var models = await ((IInt64ListbigintArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(11));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
            asPartInterface: typeof(IInt64ListbigintArray)
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
                 foreach(var batchResult in ((IInt64ListbigintArray)this).DbConnectionSelectModelBatch(connection, 66234440, 675723701))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(28));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                await foreach(var batchResult in ((IInt64ListbigintArray)this).DbConnectionSelectModelBatchAsync(connection, 927274065, 919680782))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(9));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_int64bigintarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
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
FROM public.binary_int64bigintarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
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

                var importCollection = new List<Int64bigintArray2MI>(7);

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 113727466,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 118270711,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 164516609,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 315849548,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 657772507,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 694960872,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 1068735979,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(113727466));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(118270711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(164516609));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(315849548));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(657772507));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(694960872));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(1068735979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                new Int64bigintArray2MI
                {
                    Id = 1075285206,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 1089314455,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 1120633593,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 1124116964,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 1431435208,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

},
                    NullableValue = null
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 1588648923,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 1717110302,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

}
                });

                importCollection.Add(
                new Int64bigintArray2MI
                {
                    Id = 2054626758,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(113727466));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(118270711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(164516609));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(315849548));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
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
                Assert.That(model.Id, Is.EqualTo(657772507));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(694960872));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(1068735979));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(1075285206));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(1089314455));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(1120633593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(1124116964));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(1431435208));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1588648923));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(1717110302));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(2054626758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
COPY public.binary_int64bigintarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
int64bigintarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(Int64bigintArray2M),
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
FROM public.binary_int64bigintarray2m m
LEFT JOIN public.binary_int64bigintarray2mi mi ON mi.id = m.int64bigintarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(Int64bigintArray2M),
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

                var importCollection = new List<Int64bigintArray2M>(15);

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 25706917,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 66234440,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 115453654,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1588648923
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 176635402,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1089314455
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 178932640,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 279780229,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 315687868,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1717110302
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 423165133,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 113727466
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 461697494,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1124116964
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 502858657,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1068735979
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 534808018,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 164516609
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 630115869,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 118270711
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 667655934,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1075285206
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 675723701,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 719038842,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25706917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(66234440));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                new Int64bigintArray2M
                {
                    Id = 773112634,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 694960872
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 776058429,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1120633593
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 827877573,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

},
                    NullableValue = null,

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 657772507
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 851629924,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 919680782,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 927274065,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 2054626758
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 972727078,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 1107214713,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 1326167488,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 1337707405,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 1431435208
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 1606309445,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 1716292140,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 2123850416,
                    Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

},

                    ModelInner = new Int64bigintArray2MI 
                    {
                        Id = 315849548
                    }

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 2139501794,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

},
                    NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

},

                    ModelInner = null

                });

                importCollection.Add(
                new Int64bigintArray2M
                {
                    Id = 2139664898,
                    Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

},
                    NullableValue = null,

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25706917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(66234440));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(115453654));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1588648923));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

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
                Assert.That(model.Id, Is.EqualTo(176635402));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089314455));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

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
                Assert.That(model.Id, Is.EqualTo(178932640));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

};
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
                Assert.That(model.Id, Is.EqualTo(279780229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(315687868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1717110302));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

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
                Assert.That(model.Id, Is.EqualTo(423165133));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(113727466));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

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
                Assert.That(model.Id, Is.EqualTo(461697494));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1124116964));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

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
                Assert.That(model.Id, Is.EqualTo(502858657));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1068735979));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

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
                Assert.That(model.Id, Is.EqualTo(534808018));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(164516609));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

};
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
                Assert.That(model.Id, Is.EqualTo(630115869));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(118270711));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

};
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
                Assert.That(model.Id, Is.EqualTo(667655934));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1075285206));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

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
                Assert.That(model.Id, Is.EqualTo(675723701));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(719038842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(773112634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(694960872));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

};
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
                Assert.That(model.Id, Is.EqualTo(776058429));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1120633593));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

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
                Assert.That(model.Id, Is.EqualTo(827877573));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(657772507));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

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
                Assert.That(model.Id, Is.EqualTo(851629924));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(919680782));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

};
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
                Assert.That(model.Id, Is.EqualTo(927274065));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054626758));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

};
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
                Assert.That(model.Id, Is.EqualTo(972727078));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

};
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
                Assert.That(model.Id, Is.EqualTo(1107214713));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1326167488));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1337707405));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1431435208));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

};
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
                Assert.That(model.Id, Is.EqualTo(1606309445));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

};
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
                Assert.That(model.Id, Is.EqualTo(1716292140));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2123850416));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(315849548));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


                model = models[28];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2139501794));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

};
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
                Assert.That(model.Id, Is.EqualTo(2139664898));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
COPY public.binary_int64bigintarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    int64bigintarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(Int64bigintArray2M),
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

                var expected = new Dictionary<System.Int32,Int64bigintArray2M>(30);

                expected.Add(
                    25706917,
                    new Int64bigintArray2M
                    {
                        Id = 25706917,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    66234440,
                    new Int64bigintArray2M
                    {
                        Id = 66234440,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    115453654,
                    new Int64bigintArray2M
                    {
                        Id = 115453654,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1588648923,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

}
                        }

                    }
                );

                expected.Add(
                    176635402,
                    new Int64bigintArray2M
                    {
                        Id = 176635402,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1089314455,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

}
                        }

                    }
                );

                expected.Add(
                    178932640,
                    new Int64bigintArray2M
                    {
                        Id = 178932640,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    279780229,
                    new Int64bigintArray2M
                    {
                        Id = 279780229,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    315687868,
                    new Int64bigintArray2M
                    {
                        Id = 315687868,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1717110302,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

}
                        }

                    }
                );

                expected.Add(
                    423165133,
                    new Int64bigintArray2M
                    {
                        Id = 423165133,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 113727466,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

}
                        }

                    }
                );

                expected.Add(
                    461697494,
                    new Int64bigintArray2M
                    {
                        Id = 461697494,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1124116964,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

}
                        }

                    }
                );

                expected.Add(
                    502858657,
                    new Int64bigintArray2M
                    {
                        Id = 502858657,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1068735979,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

}
                        }

                    }
                );

                expected.Add(
                    534808018,
                    new Int64bigintArray2M
                    {
                        Id = 534808018,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 164516609,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    630115869,
                    new Int64bigintArray2M
                    {
                        Id = 630115869,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 118270711,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    667655934,
                    new Int64bigintArray2M
                    {
                        Id = 667655934,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1075285206,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

}
                        }

                    }
                );

                expected.Add(
                    675723701,
                    new Int64bigintArray2M
                    {
                        Id = 675723701,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    719038842,
                    new Int64bigintArray2M
                    {
                        Id = 719038842,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    773112634,
                    new Int64bigintArray2M
                    {
                        Id = 773112634,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 694960872,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    776058429,
                    new Int64bigintArray2M
                    {
                        Id = 776058429,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1120633593,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

}
                        }

                    }
                );

                expected.Add(
                    827877573,
                    new Int64bigintArray2M
                    {
                        Id = 827877573,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 657772507,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

}
                        }

                    }
                );

                expected.Add(
                    851629924,
                    new Int64bigintArray2M
                    {
                        Id = 851629924,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    919680782,
                    new Int64bigintArray2M
                    {
                        Id = 919680782,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    927274065,
                    new Int64bigintArray2M
                    {
                        Id = 927274065,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 2054626758,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    972727078,
                    new Int64bigintArray2M
                    {
                        Id = 972727078,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1107214713,
                    new Int64bigintArray2M
                    {
                        Id = 1107214713,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1326167488,
                    new Int64bigintArray2M
                    {
                        Id = 1326167488,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1337707405,
                    new Int64bigintArray2M
                    {
                        Id = 1337707405,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1431435208,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1606309445,
                    new Int64bigintArray2M
                    {
                        Id = 1606309445,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1716292140,
                    new Int64bigintArray2M
                    {
                        Id = 1716292140,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2123850416,
                    new Int64bigintArray2M
                    {
                        Id = 2123850416,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 315849548,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2139501794,
                    new Int64bigintArray2M
                    {
                        Id = 2139501794,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2139664898,
                    new Int64bigintArray2M
                    {
                        Id = 2139664898,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
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

                var expected = new Dictionary<System.Int32,Int64bigintArray2M>(30);

                expected.Add(
                    25706917,
                    new Int64bigintArray2M
                    {
                        Id = 25706917,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4056422823649262297L,

248245041303300009L,

4062211929507774476L,

8080407870021701089L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    66234440,
                    new Int64bigintArray2M
                    {
                        Id = 66234440,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2223947376630808405L,

7849214641829108508L,

45570172278956548L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    115453654,
                    new Int64bigintArray2M
                    {
                        Id = 115453654,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3213633465836682868L,

6021828731553810660L,

926499593362941909L,

8927319566076119003L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1588648923,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

}
                        }

                    }
                );

                expected.Add(
                    176635402,
                    new Int64bigintArray2M
                    {
                        Id = 176635402,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2425389034260876641L,

6248573392694640654L,

6714177961560049058L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1089314455,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

}
                        }

                    }
                );

                expected.Add(
                    178932640,
                    new Int64bigintArray2M
                    {
                        Id = 178932640,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5885189257782543517L,

5670928197015931633L,

6825194963293883947L,

4722646680700996202L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5931712361220009121L,

9068996415433713825L,

4265172172136446366L,

6566644921849017346L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    279780229,
                    new Int64bigintArray2M
                    {
                        Id = 279780229,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4996726852132567360L,

8185762262484342479L,

2114219225985236472L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    315687868,
                    new Int64bigintArray2M
                    {
                        Id = 315687868,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
463562563122111623L,

7361301810394830386L,

6937631887639706728L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
3920714424491885710L,

7983914733806755294L,

5881522288970505160L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1717110302,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

}
                        }

                    }
                );

                expected.Add(
                    423165133,
                    new Int64bigintArray2M
                    {
                        Id = 423165133,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2644125652074421828L,

2097642818443919812L,

6417393957296676587L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2941520570604852329L,

1576674204486806698L,

636410981674132422L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 113727466,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

}
                        }

                    }
                );

                expected.Add(
                    461697494,
                    new Int64bigintArray2M
                    {
                        Id = 461697494,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3308665310266349370L,

2423706447784667970L,

8728267374806142790L,

5160807347109015548L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
3523540052627888705L,

4514887998242993780L,

3755476557038237711L,

7446564502373421299L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1124116964,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

}
                        }

                    }
                );

                expected.Add(
                    502858657,
                    new Int64bigintArray2M
                    {
                        Id = 502858657,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7064007854746456739L,

8052092082083008690L,

8451951704787219100L,

4413402725649948449L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5661310498255316894L,

5073155097853120749L,

2390936250844555914L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1068735979,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

}
                        }

                    }
                );

                expected.Add(
                    534808018,
                    new Int64bigintArray2M
                    {
                        Id = 534808018,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
601016893323344300L,

5975384550870887205L,

3476454034241027617L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
9018522779054119709L,

3012147757454527499L,

7210568577836057230L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 164516609,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    630115869,
                    new Int64bigintArray2M
                    {
                        Id = 630115869,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3949532558606848370L,

1476842899717171155L,

152117518711050561L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 118270711,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    667655934,
                    new Int64bigintArray2M
                    {
                        Id = 667655934,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3418767471161723489L,

1819068933163599117L,

7492578412109438411L,

4919961025089347895L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1075285206,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

}
                        }

                    }
                );

                expected.Add(
                    675723701,
                    new Int64bigintArray2M
                    {
                        Id = 675723701,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3633002636963063884L,

3427981168688128982L,

2817232117755617394L,

58623662870926120L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    719038842,
                    new Int64bigintArray2M
                    {
                        Id = 719038842,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7397440677162774760L,

3269299129770185129L,

4257972930979113658L,

5140677635146094294L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    773112634,
                    new Int64bigintArray2M
                    {
                        Id = 773112634,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3261419031481739531L,

168331924708065089L,

6084027753261738581L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 694960872,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    776058429,
                    new Int64bigintArray2M
                    {
                        Id = 776058429,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5468427280681638946L,

899466186942789772L,

9055454239988007073L,

897952260655819759L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1235173953396713067L,

1542302755960791279L,

9034739652706618646L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1120633593,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

}
                        }

                    }
                );

                expected.Add(
                    827877573,
                    new Int64bigintArray2M
                    {
                        Id = 827877573,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
9206687370168585513L,

441282827867901592L,

963317685325313643L,

},
                        NullableValue = null,

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 657772507,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

},
                            NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

}
                        }

                    }
                );

                expected.Add(
                    851629924,
                    new Int64bigintArray2M
                    {
                        Id = 851629924,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3560382116665773507L,

4813267264055081818L,

4991907698939628624L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    919680782,
                    new Int64bigintArray2M
                    {
                        Id = 919680782,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
4576956107280095356L,

443833767087679625L,

4798354903792508078L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2548108076548316425L,

5440928224921084860L,

287740364667535089L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    927274065,
                    new Int64bigintArray2M
                    {
                        Id = 927274065,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4248269057464027222L,

1431872396234307465L,

8848423552108514325L,

4094519626838944960L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
2436769914319601413L,

431732431308975703L,

2483548505495739443L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 2054626758,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    972727078,
                    new Int64bigintArray2M
                    {
                        Id = 972727078,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
6436434149603364114L,

1117546622654910142L,

61528042689015749L,

6716192258997380102L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
9174589303634609603L,

4444342112737912L,

7399865217687428768L,

237402608768432983L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1107214713,
                    new Int64bigintArray2M
                    {
                        Id = 1107214713,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3853044045103429707L,

9049450720176243977L,

5011521353871858209L,

8066898643343367384L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1326167488,
                    new Int64bigintArray2M
                    {
                        Id = 1326167488,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3316697569294989762L,

7386635753497066894L,

6108524228068428910L,

6532561859493480486L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1337707405,
                    new Int64bigintArray2M
                    {
                        Id = 1337707405,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
3629005630784120991L,

8313907589540877843L,

1346208596764252540L,

717743723057881631L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
1947063465596266441L,

8304902283817064483L,

1526848755168837464L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 1431435208,
                            Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1606309445,
                    new Int64bigintArray2M
                    {
                        Id = 1606309445,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
232586605410859487L,

5484000151783888194L,

4272154343373846043L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
615507096571132135L,

7943643208527248440L,

5295607141464459543L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1716292140,
                    new Int64bigintArray2M
                    {
                        Id = 1716292140,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
9057448039626593272L,

6955485080768817484L,

8076062961034170176L,

7183222325373084678L,

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2123850416,
                    new Int64bigintArray2M
                    {
                        Id = 2123850416,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
2080602044529578650L,

406253437256747288L,

5211912354077449204L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2365301863547932094L,

1323776053413837010L,

6850235892314607497L,

3798575380955039693L,

},

                        ModelInner = new Int64bigintArray2MI
                        {
                            Id = 315849548,
                            Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2139501794,
                    new Int64bigintArray2M
                    {
                        Id = 2139501794,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5556512667364360907L,

2018636797409420265L,

4414287673493670549L,

2874373581641804515L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4537764732330369868L,

8862865269639060612L,

4778940580918234536L,

9007161530971547392L,

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2139664898,
                    new Int64bigintArray2M
                    {
                        Id = 2139664898,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5396222403104352473L,

7799268068235275567L,

3671326222273490057L,

7574746569738904172L,

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Int64>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_int64bigintarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(Int64bigintArray2MI),
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

                var expected = new Dictionary<System.Int32,Int64bigintArray2MI>(15);

                expected.Add(
                    113727466,
                    new Int64bigintArray2MI
                    {
                        Id = 113727466,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

}
                    }
                );

                expected.Add(
                    118270711,
                    new Int64bigintArray2MI
                    {
                        Id = 118270711,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    164516609,
                    new Int64bigintArray2MI
                    {
                        Id = 164516609,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    315849548,
                    new Int64bigintArray2MI
                    {
                        Id = 315849548,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    657772507,
                    new Int64bigintArray2MI
                    {
                        Id = 657772507,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

}
                    }
                );

                expected.Add(
                    694960872,
                    new Int64bigintArray2MI
                    {
                        Id = 694960872,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1068735979,
                    new Int64bigintArray2MI
                    {
                        Id = 1068735979,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

}
                    }
                );

                expected.Add(
                    1075285206,
                    new Int64bigintArray2MI
                    {
                        Id = 1075285206,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

}
                    }
                );

                expected.Add(
                    1089314455,
                    new Int64bigintArray2MI
                    {
                        Id = 1089314455,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

}
                    }
                );

                expected.Add(
                    1120633593,
                    new Int64bigintArray2MI
                    {
                        Id = 1120633593,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

}
                    }
                );

                expected.Add(
                    1124116964,
                    new Int64bigintArray2MI
                    {
                        Id = 1124116964,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

}
                    }
                );

                expected.Add(
                    1431435208,
                    new Int64bigintArray2MI
                    {
                        Id = 1431435208,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1588648923,
                    new Int64bigintArray2MI
                    {
                        Id = 1588648923,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

}
                    }
                );

                expected.Add(
                    1717110302,
                    new Int64bigintArray2MI
                    {
                        Id = 1717110302,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

}
                    }
                );

                expected.Add(
                    2054626758,
                    new Int64bigintArray2MI
                    {
                        Id = 2054626758,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

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

                var expected = new Dictionary<System.Int32,Int64bigintArray2MI>(15);

                expected.Add(
                    113727466,
                    new Int64bigintArray2MI
                    {
                        Id = 113727466,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4155789880455937935L,

8563833728302603804L,

5165628538747691576L,

7592092493249350446L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
2718816866079548928L,

8104917339063567576L,

4305232327935307931L,

1419646723154492976L,

}
                    }
                );

                expected.Add(
                    118270711,
                    new Int64bigintArray2MI
                    {
                        Id = 118270711,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7371316069998895807L,

736457136738010385L,

1495464956627019688L,

8667493681611594705L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    164516609,
                    new Int64bigintArray2MI
                    {
                        Id = 164516609,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
4872283608028751943L,

1089608109050811629L,

4368966248082947099L,

7745201482517349705L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    315849548,
                    new Int64bigintArray2MI
                    {
                        Id = 315849548,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3642772531230218918L,

4357501940787978247L,

5530467452049461840L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    657772507,
                    new Int64bigintArray2MI
                    {
                        Id = 657772507,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
7488343408189945135L,

7817895951802593315L,

3050604189527279112L,

6690915342559890723L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
452704042333465837L,

4007954510964963314L,

4359214019278512668L,

87062284729444461L,

}
                    }
                );

                expected.Add(
                    694960872,
                    new Int64bigintArray2MI
                    {
                        Id = 694960872,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3038586910137457110L,

3777983647600796848L,

162890485309602444L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1068735979,
                    new Int64bigintArray2MI
                    {
                        Id = 1068735979,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
6091744141225063342L,

1818889248339612381L,

4266892784680725727L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
8760721705180408865L,

1751186068017391219L,

1252769995623058117L,

8341704049306918873L,

}
                    }
                );

                expected.Add(
                    1075285206,
                    new Int64bigintArray2MI
                    {
                        Id = 1075285206,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3508817248842325833L,

3206528439234030264L,

1763052077274447127L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
5814614015611235586L,

2192944690970477000L,

4371295764062331510L,

6084255253923584786L,

}
                    }
                );

                expected.Add(
                    1089314455,
                    new Int64bigintArray2MI
                    {
                        Id = 1089314455,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8504964799498681820L,

8892177617941994310L,

6920621575008161423L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
4130191175270960321L,

2513811813133031508L,

7562890583675685075L,

}
                    }
                );

                expected.Add(
                    1120633593,
                    new Int64bigintArray2MI
                    {
                        Id = 1120633593,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5627888324662406798L,

1720076004175876050L,

7630632875208287978L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
1667277422963401021L,

8159489491097790652L,

9022067668778241480L,

6815101381071088418L,

}
                    }
                );

                expected.Add(
                    1124116964,
                    new Int64bigintArray2MI
                    {
                        Id = 1124116964,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
5509519245322551513L,

6091263190277543234L,

3945007142882401197L,

8724556910588352735L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(4)
{
4747803968480315151L,

45800987328747047L,

6205183828946677599L,

2096997225335842519L,

}
                    }
                );

                expected.Add(
                    1431435208,
                    new Int64bigintArray2MI
                    {
                        Id = 1431435208,
                        Value = 
new System.Collections.Generic.List<System.Int64>(4)
{
705378061126486748L,

6449902854247724625L,

1197986833924868782L,

5963426739112262626L,

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1588648923,
                    new Int64bigintArray2MI
                    {
                        Id = 1588648923,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
3604789050966696791L,

8954250922722703560L,

908059512079569460L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
6122630606285613329L,

5395582871303451101L,

3794447001286644130L,

}
                    }
                );

                expected.Add(
                    1717110302,
                    new Int64bigintArray2MI
                    {
                        Id = 1717110302,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
5636454260954622300L,

8416392767787877996L,

6906483953795365004L,

},
                        NullableValue = 
new System.Collections.Generic.List<System.Int64>(3)
{
5008060052153349130L,

5608845450647985564L,

488407304283858307L,

}
                    }
                );

                expected.Add(
                    2054626758,
                    new Int64bigintArray2MI
                    {
                        Id = 2054626758,
                        Value = 
new System.Collections.Generic.List<System.Int64>(3)
{
8409663101118962463L,

9096113625442252532L,

3315100458462794966L,

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

