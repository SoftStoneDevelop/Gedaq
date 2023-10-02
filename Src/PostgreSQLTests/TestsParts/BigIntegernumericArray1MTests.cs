

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
    internal partial interface IBigIntegerArraynumericArray
    {
    }
    
    internal partial class BigIntegerArraynumericArray : IBigIntegerArraynumericArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1mi(
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
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
INSERT INTO public.bigintegernumericarray1mi(
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
            queryMapType: typeof(BigIntegernumericArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, 195977345, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModelInner(connection, 1089581039, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, 1710069767, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelInnerAsync(connection, 68670740, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, 46563213, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

});
                Assert.That(id, Is.EqualTo(46563213));

                id =  ((IBigIntegerArraynumericArray)this).InsertModelInnerReturning(connection, 1557353862, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

}, null);
                Assert.That(id, Is.EqualTo(1557353862));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 1800125694, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

});
                Assert.That(id, Is.EqualTo(1800125694));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 968595563, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

}, null);
                Assert.That(id, Is.EqualTo(968595563));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 980102373, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

}, null);
                Assert.That(id, Is.EqualTo(980102373));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 295202428, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

});
                Assert.That(id, Is.EqualTo(295202428));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 1253273948, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

}, null);
                Assert.That(id, Is.EqualTo(1253273948));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 1237245154, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

}, null);
                Assert.That(id, Is.EqualTo(1237245154));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 490916245, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

}, null);
                Assert.That(id, Is.EqualTo(490916245));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 313424198, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

});
                Assert.That(id, Is.EqualTo(313424198));

                id = await ((IBigIntegerArraynumericArray)this).InsertModelInnerReturningAsync(connection, 1267285827, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

}, null);
                Assert.That(id, Is.EqualTo(1267285827));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
            asPartInterface: typeof(IBigIntegerArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, 1197866041, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerArraynumericArray)this).InsertModel(connection, 808011287, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

}, null, 195977345);
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

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, 1486807793, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerArraynumericArray)this).InsertModelAsync(connection, 710152948, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

}, 1089581039);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            
        }

        [Ignore("Invalid cast, ExecuteScalar provider return wrong type")]
        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray1m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray1mi_id
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
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(BigIntegernumericArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Numerics.BigInteger[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray1mi_id", 
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
                List<BigIntegernumericArray1M> models = null;
                BigIntegernumericArray1M model = null;

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, 697778228, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, 1944596582, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

}, null, 1710069767).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, 1806321239, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBigIntegerArraynumericArray)this).InsertModelReturning(connection, 1332787226, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

}, null, 68670740).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray1M> models = null;
                BigIntegernumericArray1M model = null;

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 813006845, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1292360330, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

}, 46563213).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 426491655, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(426491655));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 2017263727, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

}, 1557353862).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1307621321, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 736952484, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

}, null, 1800125694).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 594126040, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(594126040));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 893006212, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

}, null, 968595563).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 995027061, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1198734753, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

}, 980102373).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1564650422, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1423153218, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

}, 295202428).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1961397490, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 735455434, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

}, null, 1253273948).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 628822737, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

}, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(628822737));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 209170628, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

}, null, 1237245154).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(209170628));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237245154));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 823374799, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1485252934, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

}, null, 490916245).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1285326360, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 670265961, 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

}, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

}, 313424198).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 768676719, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerArraynumericArray)this).InsertModelReturningAsync(connection, 1890767241, 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

}, null, 1267285827).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(BigIntegernumericArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)
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
                var models =  ((IBigIntegerArraynumericArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(209170628));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237245154));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

};
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
                Assert.That(model.Id, Is.EqualTo(426491655));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(594126040));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

};
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
                Assert.That(model.Id, Is.EqualTo(628822737));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

};
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
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(209170628));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237245154));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

};
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
                Assert.That(model.Id, Is.EqualTo(426491655));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(594126040));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

};
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
                Assert.That(model.Id, Is.EqualTo(628822737));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

};
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
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
FROM public.bigintegernumericarray1m m
LEFT JOIN public.bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(BigIntegernumericArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)
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
                var models =  ((IBigIntegerArraynumericArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(209170628));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237245154));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

};
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
                Assert.That(model.Id, Is.EqualTo(426491655));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(594126040));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

};
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
                Assert.That(model.Id, Is.EqualTo(628822737));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

};
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
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(209170628));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237245154));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

};
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
                Assert.That(model.Id, Is.EqualTo(426491655));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(594126040));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

};
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
                Assert.That(model.Id, Is.EqualTo(628822737));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

};
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
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 823374799);
                var models =  ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(17));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IBigIntegerArraynumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerArraynumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 1486807793);
                var models = await ((IBigIntegerArraynumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(6));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerArraynumericArray)
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
                 foreach(var batchResult in ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatch(connection, 670265961, 768676719))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(25));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models =  batchResult.ToList();
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
                await foreach(var batchResult in ((IBigIntegerArraynumericArray)this).DbConnectionSelectModelBatchAsync(connection, 628822737, 1564650422))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(26));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = await batchResult.ToListAsync();
                        Assert.That(models, Has.Count.EqualTo(5));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);

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
COPY public.binary_bigintegernumericarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
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
FROM public.binary_bigintegernumericarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
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

                var importCollection = new List<BigIntegernumericArray1MI>(7);

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 46563213,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 68670740,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 195977345,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 295202428,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 313424198,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 490916245,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 968595563,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46563213));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(68670740));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(195977345));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(295202428));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(313424198));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(490916245));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(968595563));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                new BigIntegernumericArray1MI
                {
                    Id = 980102373,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 1089581039,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 1237245154,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 1253273948,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 1267285827,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 1557353862,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 1710069767,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray1MI
                {
                    Id = 1800125694,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(46563213));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(68670740));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(195977345));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(295202428));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(313424198));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(490916245));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(968595563));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(980102373));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1089581039));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(1237245154));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

};
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
                Assert.That(model.Id, Is.EqualTo(1253273948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(1267285827));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1557353862));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
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
                Assert.That(model.Id, Is.EqualTo(1710069767));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1800125694));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
COPY public.binary_bigintegernumericarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
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
FROM public.binary_bigintegernumericarray1m m
LEFT JOIN public.binary_bigintegernumericarray1mi mi ON mi.id = m.bigintegernumericarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
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

                var importCollection = new List<BigIntegernumericArray1M>(15);

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 209170628,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 1237245154
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 426491655,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 594126040,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 628822737,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 670265961,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

},

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 313424198
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 697778228,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 710152948,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

},

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 1089581039
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 735455434,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 1253273948
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 736952484,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 1800125694
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 768676719,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 808011287,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 195977345
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 813006845,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 823374799,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 893006212,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 968595563
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 995027061,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(209170628));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237245154));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

};
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
                Assert.That(model.Id, Is.EqualTo(426491655));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(594126040));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

};
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
                Assert.That(model.Id, Is.EqualTo(628822737));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

};
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
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                new BigIntegernumericArray1M
                {
                    Id = 1197866041,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1198734753,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

},

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 980102373
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1285326360,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1292360330,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

},

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 46563213
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1307621321,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

},
                    NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1332787226,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 68670740
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1423153218,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

},

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 295202428
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1485252934,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 490916245
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1486807793,
                    Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1564650422,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1806321239,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1890767241,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 1267285827
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1944596582,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 1710069767
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 1961397490,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray1M
                {
                    Id = 2017263727,
                    Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

},
                    NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

},

                    ModelInner = new BigIntegernumericArray1MI 
                    {
                        Id = 1557353862
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(209170628));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1237245154));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

};
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
                Assert.That(model.Id, Is.EqualTo(426491655));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(594126040));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

};
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
                Assert.That(model.Id, Is.EqualTo(628822737));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

};
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
                Assert.That(model.Id, Is.EqualTo(670265961));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(313424198));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

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
                Assert.That(model.Id, Is.EqualTo(697778228));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(710152948));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1089581039));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

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
                Assert.That(model.Id, Is.EqualTo(735455434));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1253273948));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

};
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
                Assert.That(model.Id, Is.EqualTo(736952484));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1800125694));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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
                Assert.That(model.Id, Is.EqualTo(768676719));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(808011287));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(195977345));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

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
                Assert.That(model.Id, Is.EqualTo(813006845));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

};
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
                Assert.That(model.Id, Is.EqualTo(823374799));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(893006212));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(968595563));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

};
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
                Assert.That(model.Id, Is.EqualTo(995027061));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1197866041));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198734753));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(980102373));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

};
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
                Assert.That(model.Id, Is.EqualTo(1285326360));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

};
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
                Assert.That(model.Id, Is.EqualTo(1292360330));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(46563213));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

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
                Assert.That(model.Id, Is.EqualTo(1307621321));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

};
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
                Assert.That(model.Id, Is.EqualTo(1332787226));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(68670740));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

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
                Assert.That(model.Id, Is.EqualTo(1423153218));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(295202428));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

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
                Assert.That(model.Id, Is.EqualTo(1485252934));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(490916245));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

};
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
                Assert.That(model.Id, Is.EqualTo(1486807793));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1564650422));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

};
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
                Assert.That(model.Id, Is.EqualTo(1806321239));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1890767241));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1267285827));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

};
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
                Assert.That(model.Id, Is.EqualTo(1944596582));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1710069767));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

};
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
                Assert.That(model.Id, Is.EqualTo(1961397490));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2017263727));
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1557353862));

                {
                    var expectEnumerValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Null);


            }
        }

        #endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(BigIntegernumericArray1M),
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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray1M>(30);

                expected.Add(
                    209170628,
                    new BigIntegernumericArray1M
                    {
                        Id = 209170628,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1237245154,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    426491655,
                    new BigIntegernumericArray1M
                    {
                        Id = 426491655,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    594126040,
                    new BigIntegernumericArray1M
                    {
                        Id = 594126040,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    628822737,
                    new BigIntegernumericArray1M
                    {
                        Id = 628822737,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    670265961,
                    new BigIntegernumericArray1M
                    {
                        Id = 670265961,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 313424198,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

},
                            NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

}
                        }

                    }
                );

                expected.Add(
                    697778228,
                    new BigIntegernumericArray1M
                    {
                        Id = 697778228,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    710152948,
                    new BigIntegernumericArray1M
                    {
                        Id = 710152948,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1089581039,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

}
                        }

                    }
                );

                expected.Add(
                    735455434,
                    new BigIntegernumericArray1M
                    {
                        Id = 735455434,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1253273948,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    736952484,
                    new BigIntegernumericArray1M
                    {
                        Id = 736952484,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1800125694,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

},
                            NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

}
                        }

                    }
                );

                expected.Add(
                    768676719,
                    new BigIntegernumericArray1M
                    {
                        Id = 768676719,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    808011287,
                    new BigIntegernumericArray1M
                    {
                        Id = 808011287,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 195977345,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

}
                        }

                    }
                );

                expected.Add(
                    813006845,
                    new BigIntegernumericArray1M
                    {
                        Id = 813006845,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    823374799,
                    new BigIntegernumericArray1M
                    {
                        Id = 823374799,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    893006212,
                    new BigIntegernumericArray1M
                    {
                        Id = 893006212,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 968595563,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    995027061,
                    new BigIntegernumericArray1M
                    {
                        Id = 995027061,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1197866041,
                    new BigIntegernumericArray1M
                    {
                        Id = 1197866041,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1198734753,
                    new BigIntegernumericArray1M
                    {
                        Id = 1198734753,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 980102373,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1285326360,
                    new BigIntegernumericArray1M
                    {
                        Id = 1285326360,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1292360330,
                    new BigIntegernumericArray1M
                    {
                        Id = 1292360330,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 46563213,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

}
                        }

                    }
                );

                expected.Add(
                    1307621321,
                    new BigIntegernumericArray1M
                    {
                        Id = 1307621321,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1332787226,
                    new BigIntegernumericArray1M
                    {
                        Id = 1332787226,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 68670740,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

},
                            NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

}
                        }

                    }
                );

                expected.Add(
                    1423153218,
                    new BigIntegernumericArray1M
                    {
                        Id = 1423153218,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 295202428,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

}
                        }

                    }
                );

                expected.Add(
                    1485252934,
                    new BigIntegernumericArray1M
                    {
                        Id = 1485252934,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 490916245,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1486807793,
                    new BigIntegernumericArray1M
                    {
                        Id = 1486807793,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1564650422,
                    new BigIntegernumericArray1M
                    {
                        Id = 1564650422,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1806321239,
                    new BigIntegernumericArray1M
                    {
                        Id = 1806321239,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1890767241,
                    new BigIntegernumericArray1M
                    {
                        Id = 1890767241,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1267285827,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1944596582,
                    new BigIntegernumericArray1M
                    {
                        Id = 1944596582,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1710069767,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1961397490,
                    new BigIntegernumericArray1M
                    {
                        Id = 1961397490,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2017263727,
                    new BigIntegernumericArray1M
                    {
                        Id = 2017263727,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1557353862,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray1M>(30);

                expected.Add(
                    209170628,
                    new BigIntegernumericArray1M
                    {
                        Id = 209170628,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(638035198385905460L),

new System.Numerics.BigInteger(4331022867939574185L),

new System.Numerics.BigInteger(5693986415914666561L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1237245154,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    426491655,
                    new BigIntegernumericArray1M
                    {
                        Id = 426491655,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2202971542422127477L),

new System.Numerics.BigInteger(2582150813400492200L),

new System.Numerics.BigInteger(6347018287575245767L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    594126040,
                    new BigIntegernumericArray1M
                    {
                        Id = 594126040,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(8372991458512954955L),

new System.Numerics.BigInteger(2637508095701785481L),

new System.Numerics.BigInteger(3851788539843162857L),

new System.Numerics.BigInteger(7572367075529799868L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7233879702659308843L),

new System.Numerics.BigInteger(8505847236435678903L),

new System.Numerics.BigInteger(2330037083085808546L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    628822737,
                    new BigIntegernumericArray1M
                    {
                        Id = 628822737,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1327924744070593670L),

new System.Numerics.BigInteger(1490242713173152300L),

new System.Numerics.BigInteger(4575957978347515844L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2914339179966484653L),

new System.Numerics.BigInteger(5346504329315778499L),

new System.Numerics.BigInteger(3849316537466495477L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    670265961,
                    new BigIntegernumericArray1M
                    {
                        Id = 670265961,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1456056752788544395L),

new System.Numerics.BigInteger(687748092562430173L),

new System.Numerics.BigInteger(1421162345968709444L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7922400959685792694L),

new System.Numerics.BigInteger(3884210048090499698L),

new System.Numerics.BigInteger(7773147055002953714L),

new System.Numerics.BigInteger(5853563612294928369L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 313424198,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

},
                            NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

}
                        }

                    }
                );

                expected.Add(
                    697778228,
                    new BigIntegernumericArray1M
                    {
                        Id = 697778228,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(801105580976004238L),

new System.Numerics.BigInteger(6463769235180471309L),

new System.Numerics.BigInteger(385698754624221865L),

new System.Numerics.BigInteger(4312648134602194539L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    710152948,
                    new BigIntegernumericArray1M
                    {
                        Id = 710152948,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2788096471629318100L),

new System.Numerics.BigInteger(2332927712531219642L),

new System.Numerics.BigInteger(1478759390223841069L),

new System.Numerics.BigInteger(5343389094105325406L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4708605199154380632L),

new System.Numerics.BigInteger(5505984067398137772L),

new System.Numerics.BigInteger(3186504031085250962L),

new System.Numerics.BigInteger(8737232904280854914L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1089581039,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

}
                        }

                    }
                );

                expected.Add(
                    735455434,
                    new BigIntegernumericArray1M
                    {
                        Id = 735455434,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2803692497400676795L),

new System.Numerics.BigInteger(2708087497333658624L),

new System.Numerics.BigInteger(4761842715486409648L),

new System.Numerics.BigInteger(6076174430603562898L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1253273948,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    736952484,
                    new BigIntegernumericArray1M
                    {
                        Id = 736952484,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4225797918542970659L),

new System.Numerics.BigInteger(294250622475954092L),

new System.Numerics.BigInteger(8136768563029010991L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1800125694,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

},
                            NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

}
                        }

                    }
                );

                expected.Add(
                    768676719,
                    new BigIntegernumericArray1M
                    {
                        Id = 768676719,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1206032717692758566L),

new System.Numerics.BigInteger(938740408146349224L),

new System.Numerics.BigInteger(2249547756560584591L),

new System.Numerics.BigInteger(5962347521986380677L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    808011287,
                    new BigIntegernumericArray1M
                    {
                        Id = 808011287,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6699216416083933824L),

new System.Numerics.BigInteger(1090488897754386093L),

new System.Numerics.BigInteger(8226519631719049385L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 195977345,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

}
                        }

                    }
                );

                expected.Add(
                    813006845,
                    new BigIntegernumericArray1M
                    {
                        Id = 813006845,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3086246071397529038L),

new System.Numerics.BigInteger(7460487099057644221L),

new System.Numerics.BigInteger(7928017541242202922L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4364831460154491644L),

new System.Numerics.BigInteger(7726353338992730572L),

new System.Numerics.BigInteger(7372573769219885909L),

new System.Numerics.BigInteger(3175720329265135130L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    823374799,
                    new BigIntegernumericArray1M
                    {
                        Id = 823374799,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3768631960769021448L),

new System.Numerics.BigInteger(4308198252229000592L),

new System.Numerics.BigInteger(7893298349150845163L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    893006212,
                    new BigIntegernumericArray1M
                    {
                        Id = 893006212,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(997337706588998130L),

new System.Numerics.BigInteger(5894689254982796587L),

new System.Numerics.BigInteger(7109052047273924238L),

new System.Numerics.BigInteger(3314927833645206770L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 968595563,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    995027061,
                    new BigIntegernumericArray1M
                    {
                        Id = 995027061,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5691747610112505753L),

new System.Numerics.BigInteger(2091832608566072860L),

new System.Numerics.BigInteger(6595350991539416400L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1197866041,
                    new BigIntegernumericArray1M
                    {
                        Id = 1197866041,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2284193836186748624L),

new System.Numerics.BigInteger(868448988101852763L),

new System.Numerics.BigInteger(163915109407148731L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2156524725739747254L),

new System.Numerics.BigInteger(3999730359466063146L),

new System.Numerics.BigInteger(5418824691105652988L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1198734753,
                    new BigIntegernumericArray1M
                    {
                        Id = 1198734753,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7177290406739184542L),

new System.Numerics.BigInteger(6966133084928726960L),

new System.Numerics.BigInteger(5690311123837331972L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4170434201769341445L),

new System.Numerics.BigInteger(4110963509160482758L),

new System.Numerics.BigInteger(1382292172957611425L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 980102373,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1285326360,
                    new BigIntegernumericArray1M
                    {
                        Id = 1285326360,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2055778902799004884L),

new System.Numerics.BigInteger(9010048867276996722L),

new System.Numerics.BigInteger(8154653158282291238L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2337337764079581912L),

new System.Numerics.BigInteger(2161757841048943106L),

new System.Numerics.BigInteger(3020518159610834266L),

new System.Numerics.BigInteger(4321366050268566397L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1292360330,
                    new BigIntegernumericArray1M
                    {
                        Id = 1292360330,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7128897621555433040L),

new System.Numerics.BigInteger(7102543368756965267L),

new System.Numerics.BigInteger(4419540345116445763L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(936985069051078205L),

new System.Numerics.BigInteger(1652854163208228890L),

new System.Numerics.BigInteger(2489038312691601653L),

new System.Numerics.BigInteger(3803200852554983846L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 46563213,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

}
                        }

                    }
                );

                expected.Add(
                    1307621321,
                    new BigIntegernumericArray1M
                    {
                        Id = 1307621321,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5703089924164729676L),

new System.Numerics.BigInteger(2922407943988348514L),

new System.Numerics.BigInteger(8339543262244774030L),

new System.Numerics.BigInteger(781026714758340105L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4766536720810365498L),

new System.Numerics.BigInteger(3788958065011956792L),

new System.Numerics.BigInteger(6216462308722259607L),

new System.Numerics.BigInteger(3419784089031872232L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1332787226,
                    new BigIntegernumericArray1M
                    {
                        Id = 1332787226,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2911075485051539800L),

new System.Numerics.BigInteger(221219583395395226L),

new System.Numerics.BigInteger(1465783594280758448L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 68670740,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

},
                            NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

}
                        }

                    }
                );

                expected.Add(
                    1423153218,
                    new BigIntegernumericArray1M
                    {
                        Id = 1423153218,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4716031959145939281L),

new System.Numerics.BigInteger(659396032061914738L),

new System.Numerics.BigInteger(7574529513087319661L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4348887618472411850L),

new System.Numerics.BigInteger(4416489904756647705L),

new System.Numerics.BigInteger(5316541631556695679L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 295202428,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

},
                            NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

}
                        }

                    }
                );

                expected.Add(
                    1485252934,
                    new BigIntegernumericArray1M
                    {
                        Id = 1485252934,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1704725011654613059L),

new System.Numerics.BigInteger(5471242005072698428L),

new System.Numerics.BigInteger(3923709620511459693L),

new System.Numerics.BigInteger(4109621387637156974L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 490916245,
                            Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1486807793,
                    new BigIntegernumericArray1M
                    {
                        Id = 1486807793,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(7768160664422479212L),

new System.Numerics.BigInteger(1605624081298541932L),

new System.Numerics.BigInteger(3496540845050237073L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1564650422,
                    new BigIntegernumericArray1M
                    {
                        Id = 1564650422,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1709518479465749341L),

new System.Numerics.BigInteger(7998523364458363646L),

new System.Numerics.BigInteger(5251576619344611560L),

new System.Numerics.BigInteger(8787313466227869243L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(4252732200464956314L),

new System.Numerics.BigInteger(1420161930027167598L),

new System.Numerics.BigInteger(4196362989271770469L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1806321239,
                    new BigIntegernumericArray1M
                    {
                        Id = 1806321239,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4884654044770617855L),

new System.Numerics.BigInteger(4653711900519892295L),

new System.Numerics.BigInteger(7324431586563226070L),

new System.Numerics.BigInteger(1716620062573216502L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1890767241,
                    new BigIntegernumericArray1M
                    {
                        Id = 1890767241,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6644215312359461505L),

new System.Numerics.BigInteger(6433939872456007550L),

new System.Numerics.BigInteger(2761061105033598709L),

new System.Numerics.BigInteger(6218592754116437060L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1267285827,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1944596582,
                    new BigIntegernumericArray1M
                    {
                        Id = 1944596582,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6378991830725504521L),

new System.Numerics.BigInteger(1529318463773013901L),

new System.Numerics.BigInteger(7481922437107363207L),

new System.Numerics.BigInteger(8365823700194335121L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1710069767,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1961397490,
                    new BigIntegernumericArray1M
                    {
                        Id = 1961397490,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5983140049634690144L),

new System.Numerics.BigInteger(7827573765448636868L),

new System.Numerics.BigInteger(5434567846464217814L),

new System.Numerics.BigInteger(704487217099446036L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2017263727,
                    new BigIntegernumericArray1M
                    {
                        Id = 2017263727,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1006892606258228193L),

new System.Numerics.BigInteger(3659068612555107108L),

new System.Numerics.BigInteger(8156976454514047005L),

new System.Numerics.BigInteger(3955370354009561010L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5580049685409544149L),

new System.Numerics.BigInteger(1075732714483653937L),

new System.Numerics.BigInteger(3811370422758868201L),

},

                        ModelInner = new BigIntegernumericArray1MI
                        {
                            Id = 1557353862,
                            Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

},
                            NullableValue = null
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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Numerics.BigInteger[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(BigIntegernumericArray1MI),
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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray1MI>(15);

                expected.Add(
                    46563213,
                    new BigIntegernumericArray1MI
                    {
                        Id = 46563213,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

}
                    }
                );

                expected.Add(
                    68670740,
                    new BigIntegernumericArray1MI
                    {
                        Id = 68670740,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

}
                    }
                );

                expected.Add(
                    195977345,
                    new BigIntegernumericArray1MI
                    {
                        Id = 195977345,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

}
                    }
                );

                expected.Add(
                    295202428,
                    new BigIntegernumericArray1MI
                    {
                        Id = 295202428,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

}
                    }
                );

                expected.Add(
                    313424198,
                    new BigIntegernumericArray1MI
                    {
                        Id = 313424198,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

}
                    }
                );

                expected.Add(
                    490916245,
                    new BigIntegernumericArray1MI
                    {
                        Id = 490916245,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    968595563,
                    new BigIntegernumericArray1MI
                    {
                        Id = 968595563,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    980102373,
                    new BigIntegernumericArray1MI
                    {
                        Id = 980102373,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1089581039,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1089581039,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

}
                    }
                );

                expected.Add(
                    1237245154,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1237245154,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1253273948,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1253273948,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1267285827,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1267285827,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1557353862,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1557353862,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1710069767,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1710069767,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1800125694,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1800125694,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray1MI>(15);

                expected.Add(
                    46563213,
                    new BigIntegernumericArray1MI
                    {
                        Id = 46563213,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1064064478087422288L),

new System.Numerics.BigInteger(6188250217142799778L),

new System.Numerics.BigInteger(7071655296790036892L),

new System.Numerics.BigInteger(8912057953011131429L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6423351635031880658L),

new System.Numerics.BigInteger(69919139665621322L),

new System.Numerics.BigInteger(5272790544196867039L),

}
                    }
                );

                expected.Add(
                    68670740,
                    new BigIntegernumericArray1MI
                    {
                        Id = 68670740,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(287799838021677612L),

new System.Numerics.BigInteger(2940660321175133934L),

new System.Numerics.BigInteger(3000502613947089936L),

new System.Numerics.BigInteger(2218454165328786512L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3785188064613789988L),

new System.Numerics.BigInteger(7893885427874286599L),

new System.Numerics.BigInteger(2699686843671744270L),

new System.Numerics.BigInteger(7709355565665730281L),

}
                    }
                );

                expected.Add(
                    195977345,
                    new BigIntegernumericArray1MI
                    {
                        Id = 195977345,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(3477597949927808343L),

new System.Numerics.BigInteger(6422709745347165364L),

new System.Numerics.BigInteger(4087070732375438166L),

new System.Numerics.BigInteger(3848470740829782160L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(3537072510064142753L),

new System.Numerics.BigInteger(5244430142362716476L),

new System.Numerics.BigInteger(8231325680342236766L),

}
                    }
                );

                expected.Add(
                    295202428,
                    new BigIntegernumericArray1MI
                    {
                        Id = 295202428,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(5364198326433613335L),

new System.Numerics.BigInteger(4432133598965357063L),

new System.Numerics.BigInteger(4737378086948205127L),

new System.Numerics.BigInteger(1024715632855016670L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(9065601808229648368L),

new System.Numerics.BigInteger(6882500873931146653L),

new System.Numerics.BigInteger(7457666060906899361L),

}
                    }
                );

                expected.Add(
                    313424198,
                    new BigIntegernumericArray1MI
                    {
                        Id = 313424198,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(2084821067618898727L),

new System.Numerics.BigInteger(6781750346290309424L),

new System.Numerics.BigInteger(3558003814255021297L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(7364766974847371520L),

new System.Numerics.BigInteger(8508979230072683248L),

new System.Numerics.BigInteger(7248332219582214257L),

new System.Numerics.BigInteger(8447318814239514808L),

}
                    }
                );

                expected.Add(
                    490916245,
                    new BigIntegernumericArray1MI
                    {
                        Id = 490916245,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1749113432446588744L),

new System.Numerics.BigInteger(6542460336940626418L),

new System.Numerics.BigInteger(379551356771946476L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    968595563,
                    new BigIntegernumericArray1MI
                    {
                        Id = 968595563,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6723074270058366857L),

new System.Numerics.BigInteger(7862986006047043200L),

new System.Numerics.BigInteger(1396430166576795137L),

new System.Numerics.BigInteger(2406236358918518239L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    980102373,
                    new BigIntegernumericArray1MI
                    {
                        Id = 980102373,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(934476262462861479L),

new System.Numerics.BigInteger(273653704841896922L),

new System.Numerics.BigInteger(2375793465740939061L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1089581039,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1089581039,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(1323172211054435879L),

new System.Numerics.BigInteger(2808165663562053387L),

new System.Numerics.BigInteger(3739132046973650187L),

new System.Numerics.BigInteger(5106221900053125236L),

},
                        NullableValue = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(8203742189298446313L),

new System.Numerics.BigInteger(419679461829887220L),

new System.Numerics.BigInteger(2319320777541016550L),

}
                    }
                );

                expected.Add(
                    1237245154,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1237245154,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(5031913988021442253L),

new System.Numerics.BigInteger(8660033181140900573L),

new System.Numerics.BigInteger(8965903169742327639L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1253273948,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1253273948,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(6043622907633674279L),

new System.Numerics.BigInteger(7897282943036753369L),

new System.Numerics.BigInteger(4211428095316685170L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1267285827,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1267285827,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(6837287633947412646L),

new System.Numerics.BigInteger(5894893448640122532L),

new System.Numerics.BigInteger(1935774509483394889L),

new System.Numerics.BigInteger(3426967794701135905L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1557353862,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1557353862,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(4433648972366359558L),

new System.Numerics.BigInteger(2251780664775564588L),

new System.Numerics.BigInteger(9051485211421752519L),

new System.Numerics.BigInteger(8148727915975884294L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1710069767,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1710069767,
                        Value = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(2291643039032967457L),

new System.Numerics.BigInteger(7136085526515971452L),

new System.Numerics.BigInteger(1515051532373356168L),

new System.Numerics.BigInteger(157656138343066961L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1800125694,
                    new BigIntegernumericArray1MI
                    {
                        Id = 1800125694,
                        Value = 
new System.Numerics.BigInteger[3]
{
new System.Numerics.BigInteger(1859314743873627517L),

new System.Numerics.BigInteger(4829261428963589555L),

new System.Numerics.BigInteger(8627726802958045359L),

},
                        NullableValue = 
new System.Numerics.BigInteger[4]
{
new System.Numerics.BigInteger(543542793578956498L),

new System.Numerics.BigInteger(5439871834434992740L),

new System.Numerics.BigInteger(5782710397042343029L),

new System.Numerics.BigInteger(1133924078506152876L),

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

