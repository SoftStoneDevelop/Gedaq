

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
    internal partial interface IBigIntegerListnumericArray
    {
    }
    
    internal partial class BigIntegerListnumericArray : IBigIntegerListnumericArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2mi(
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
            asPartInterface: typeof(IBigIntegerListnumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
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
INSERT INTO public.bigintegernumericarray2mi(
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
            queryMapType: typeof(BigIntegernumericArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
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

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, 1598764917, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModelInner(connection, 1960725515, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, 739693648, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelInnerAsync(connection, 1815709177, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

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

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, 551820850, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

});
                Assert.That(id, Is.EqualTo(551820850));

                id =  ((IBigIntegerListnumericArray)this).InsertModelInnerReturning(connection, 1720130461, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

}, null);
                Assert.That(id, Is.EqualTo(1720130461));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 1851199664, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

}, null);
                Assert.That(id, Is.EqualTo(1851199664));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 1893596591, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

}, null);
                Assert.That(id, Is.EqualTo(1893596591));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 2054679547, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

});
                Assert.That(id, Is.EqualTo(2054679547));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 679443223, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

});
                Assert.That(id, Is.EqualTo(679443223));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 1198060843, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

}, null);
                Assert.That(id, Is.EqualTo(1198060843));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 2076560430, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

}, null);
                Assert.That(id, Is.EqualTo(2076560430));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 591085358, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

});
                Assert.That(id, Is.EqualTo(591085358));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 1458296791, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

});
                Assert.That(id, Is.EqualTo(1458296791));

                id = await ((IBigIntegerListnumericArray)this).InsertModelInnerReturningAsync(connection, 1920492346, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

});
                Assert.That(id, Is.EqualTo(1920492346));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
            asPartInterface: typeof(IBigIntegerListnumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
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

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, 862830099, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IBigIntegerListnumericArray)this).InsertModel(connection, 551097052, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

}, null, 1598764917);
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

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, 1863080736, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IBigIntegerListnumericArray)this).InsertModelAsync(connection, 1369411641, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

}, null, 1960725515);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.bigintegernumericarray2m(
	id,
    value,
    nullablevalue,
    bigintegernumericarray2mi_id
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
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(BigIntegernumericArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Numerics.BigInteger>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483635)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "bigintegernumericarray2mi_id", 
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
                List<BigIntegernumericArray2M> models = null;
                BigIntegernumericArray2M model = null;

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, 2021284279, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, 1068832184, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

}, 739693648).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, 799428150, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IBigIntegerListnumericArray)this).InsertModelReturning(connection, 1925555227, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

}, 1815709177).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<BigIntegernumericArray2M> models = null;
                BigIntegernumericArray2M model = null;

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 727024500, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1104169843, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

}, null, 551820850).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1375955229, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 757932427, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

}, 1720130461).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1386603023, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1300217034, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

}, null, 1851199664).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1740136444, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 939948092, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

}, null, 1893596591).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 923222103, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1992288868, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

}, 2054679547).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1020188543, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 639741758, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

}, null, 679443223).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1548532340, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1918251500, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

}, 1198060843).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 32633937, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32633937));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 270960436, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

}, null, 2076560430).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 302933392, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1553344984, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

}, 591085358).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 126323214, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 2069934029, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

}, 1458296791).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1780379271, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IBigIntegerListnumericArray)this).InsertModelReturningAsync(connection, 1870821351, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

}, 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

}, 1920492346).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(BigIntegernumericArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)
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
                var models =  ((IBigIntegerListnumericArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32633937));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

};
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
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
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
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(551097052));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1598764917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                var models = await ((IBigIntegerListnumericArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32633937));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

};
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
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
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
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(551097052));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1598764917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
FROM public.bigintegernumericarray2m m
LEFT JOIN public.bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(BigIntegernumericArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IBigIntegerListnumericArray)
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
                var models =  ((IBigIntegerListnumericArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32633937));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

};
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
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
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
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(551097052));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1598764917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                var models = await ((IBigIntegerListnumericArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32633937));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

};
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
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
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
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(551097052));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1598764917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                 using var cmd =  ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 32633937);
                var models =  ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(29));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
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
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(551097052));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1598764917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                await using var cmd = await ((IBigIntegerListnumericArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IBigIntegerListnumericArray)this).SetDbConnectionSelectModelParametrs(cmd, 639741758);
                var models = await ((IBigIntegerListnumericArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(24));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
            asPartInterface: typeof(IBigIntegerListnumericArray)
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
                 foreach(var batchResult in ((IBigIntegerListnumericArray)this).DbConnectionSelectModelBatch(connection, 639741758, 1863080736))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(24));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                        Assert.That(models, Has.Count.EqualTo(6));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                await foreach(var batchResult in ((IBigIntegerListnumericArray)this).DbConnectionSelectModelBatchAsync(connection, 1992288868, 551097052))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(2));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                        Assert.That(models, Has.Count.EqualTo(25));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
COPY public.binary_bigintegernumericarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
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
FROM public.binary_bigintegernumericarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
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

                var importCollection = new List<BigIntegernumericArray2MI>(7);

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 551820850,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 591085358,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 679443223,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 739693648,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1198060843,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1458296791,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1598764917,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(551820850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(591085358));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(679443223));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(739693648));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198060843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1458296791));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                Assert.That(model.Id, Is.EqualTo(1598764917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                new BigIntegernumericArray2MI
                {
                    Id = 1720130461,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1815709177,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1851199664,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1893596591,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

},
                    NullableValue = null
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1920492346,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 1960725515,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 2054679547,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

}
                });

                importCollection.Add(
                new BigIntegernumericArray2MI
                {
                    Id = 2076560430,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(551820850));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(591085358));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(679443223));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(739693648));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1198060843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1458296791));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
                Assert.That(model.Id, Is.EqualTo(1598764917));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(1720130461));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(1815709177));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1851199664));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1893596591));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1920492346));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1960725515));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(2054679547));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2076560430));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
COPY public.binary_bigintegernumericarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
bigintegernumericarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(BigIntegernumericArray2M),
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
FROM public.binary_bigintegernumericarray2m m
LEFT JOIN public.binary_bigintegernumericarray2mi mi ON mi.id = m.bigintegernumericarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(BigIntegernumericArray2M),
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

                var importCollection = new List<BigIntegernumericArray2M>(15);

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 32633937,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 126323214,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 270960436,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 2076560430
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 302933392,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 551097052,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1598764917
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 639741758,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 679443223
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 727024500,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 757932427,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1720130461
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 799428150,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 862830099,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 923222103,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 939948092,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1893596591
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1020188543,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1068832184,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 739693648
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1104169843,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 551820850
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32633937));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

};
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
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
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
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(551097052));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1598764917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                new BigIntegernumericArray2M
                {
                    Id = 1300217034,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1851199664
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1369411641,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

},
                    NullableValue = null,

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1960725515
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1375955229,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1386603023,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1548532340,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1553344984,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 591085358
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1740136444,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1780379271,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1863080736,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1870821351,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1920492346
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1918251500,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1198060843
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1925555227,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1815709177
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 1992288868,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 2054679547
                    }

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 2021284279,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

},

                    ModelInner = null

                });

                importCollection.Add(
                new BigIntegernumericArray2M
                {
                    Id = 2069934029,
                    Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

},

                    ModelInner = new BigIntegernumericArray2MI 
                    {
                        Id = 1458296791
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(32633937));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

};
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
                Assert.That(model.Id, Is.EqualTo(126323214));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

};
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
                Assert.That(model.Id, Is.EqualTo(270960436));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2076560430));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

};
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
                Assert.That(model.Id, Is.EqualTo(302933392));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(551097052));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1598764917));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

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
                Assert.That(model.Id, Is.EqualTo(639741758));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(679443223));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

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
                Assert.That(model.Id, Is.EqualTo(727024500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(757932427));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1720130461));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

};
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
                Assert.That(model.Id, Is.EqualTo(799428150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

};
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
                Assert.That(model.Id, Is.EqualTo(862830099));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

};
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
                Assert.That(model.Id, Is.EqualTo(923222103));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

};
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
                Assert.That(model.Id, Is.EqualTo(939948092));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1893596591));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

};
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
                Assert.That(model.Id, Is.EqualTo(1020188543));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

};
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
                Assert.That(model.Id, Is.EqualTo(1068832184));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(739693648));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

};
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
                Assert.That(model.Id, Is.EqualTo(1104169843));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(551820850));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

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
                Assert.That(model.Id, Is.EqualTo(1300217034));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1851199664));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

};
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
                Assert.That(model.Id, Is.EqualTo(1369411641));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1960725515));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

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
                Assert.That(model.Id, Is.EqualTo(1375955229));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1386603023));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

};
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
                Assert.That(model.Id, Is.EqualTo(1548532340));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1553344984));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(591085358));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

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
                Assert.That(model.Id, Is.EqualTo(1740136444));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

};
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
                Assert.That(model.Id, Is.EqualTo(1780379271));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

};
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
                Assert.That(model.Id, Is.EqualTo(1863080736));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1870821351));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1920492346));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

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
                Assert.That(model.Id, Is.EqualTo(1918251500));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1198060843));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

};
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
                Assert.That(model.Id, Is.EqualTo(1925555227));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1815709177));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

};
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
                Assert.That(model.Id, Is.EqualTo(1992288868));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2054679547));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

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
                Assert.That(model.Id, Is.EqualTo(2021284279));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

};
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
                Assert.That(model.Id, Is.EqualTo(2069934029));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1458296791));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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
COPY public.binary_bigintegernumericarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    bigintegernumericarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(BigIntegernumericArray2M),
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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray2M>(30);

                expected.Add(
                    32633937,
                    new BigIntegernumericArray2M
                    {
                        Id = 32633937,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    126323214,
                    new BigIntegernumericArray2M
                    {
                        Id = 126323214,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    270960436,
                    new BigIntegernumericArray2M
                    {
                        Id = 270960436,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 2076560430,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    302933392,
                    new BigIntegernumericArray2M
                    {
                        Id = 302933392,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    551097052,
                    new BigIntegernumericArray2M
                    {
                        Id = 551097052,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1598764917,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

}
                        }

                    }
                );

                expected.Add(
                    639741758,
                    new BigIntegernumericArray2M
                    {
                        Id = 639741758,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 679443223,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

}
                        }

                    }
                );

                expected.Add(
                    727024500,
                    new BigIntegernumericArray2M
                    {
                        Id = 727024500,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    757932427,
                    new BigIntegernumericArray2M
                    {
                        Id = 757932427,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1720130461,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    799428150,
                    new BigIntegernumericArray2M
                    {
                        Id = 799428150,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    862830099,
                    new BigIntegernumericArray2M
                    {
                        Id = 862830099,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    923222103,
                    new BigIntegernumericArray2M
                    {
                        Id = 923222103,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    939948092,
                    new BigIntegernumericArray2M
                    {
                        Id = 939948092,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1893596591,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1020188543,
                    new BigIntegernumericArray2M
                    {
                        Id = 1020188543,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1068832184,
                    new BigIntegernumericArray2M
                    {
                        Id = 1068832184,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 739693648,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1104169843,
                    new BigIntegernumericArray2M
                    {
                        Id = 1104169843,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 551820850,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

}
                        }

                    }
                );

                expected.Add(
                    1300217034,
                    new BigIntegernumericArray2M
                    {
                        Id = 1300217034,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1851199664,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1369411641,
                    new BigIntegernumericArray2M
                    {
                        Id = 1369411641,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1960725515,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

}
                        }

                    }
                );

                expected.Add(
                    1375955229,
                    new BigIntegernumericArray2M
                    {
                        Id = 1375955229,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1386603023,
                    new BigIntegernumericArray2M
                    {
                        Id = 1386603023,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1548532340,
                    new BigIntegernumericArray2M
                    {
                        Id = 1548532340,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1553344984,
                    new BigIntegernumericArray2M
                    {
                        Id = 1553344984,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 591085358,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

}
                        }

                    }
                );

                expected.Add(
                    1740136444,
                    new BigIntegernumericArray2M
                    {
                        Id = 1740136444,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1780379271,
                    new BigIntegernumericArray2M
                    {
                        Id = 1780379271,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1863080736,
                    new BigIntegernumericArray2M
                    {
                        Id = 1863080736,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1870821351,
                    new BigIntegernumericArray2M
                    {
                        Id = 1870821351,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1920492346,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

}
                        }

                    }
                );

                expected.Add(
                    1918251500,
                    new BigIntegernumericArray2M
                    {
                        Id = 1918251500,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1198060843,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1925555227,
                    new BigIntegernumericArray2M
                    {
                        Id = 1925555227,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1815709177,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1992288868,
                    new BigIntegernumericArray2M
                    {
                        Id = 1992288868,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 2054679547,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

}
                        }

                    }
                );

                expected.Add(
                    2021284279,
                    new BigIntegernumericArray2M
                    {
                        Id = 2021284279,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2069934029,
                    new BigIntegernumericArray2M
                    {
                        Id = 2069934029,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1458296791,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray2M>(30);

                expected.Add(
                    32633937,
                    new BigIntegernumericArray2M
                    {
                        Id = 32633937,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2439460648008434059L),

new System.Numerics.BigInteger(686440939635617823L),

new System.Numerics.BigInteger(7445115114254172436L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(5599257231563173350L),

new System.Numerics.BigInteger(6636703699738045679L),

new System.Numerics.BigInteger(7049196598819102696L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    126323214,
                    new BigIntegernumericArray2M
                    {
                        Id = 126323214,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7961228136746115147L),

new System.Numerics.BigInteger(7206536645731666405L),

new System.Numerics.BigInteger(1297855842061953027L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6161925087246755860L),

new System.Numerics.BigInteger(8938330171621098536L),

new System.Numerics.BigInteger(8321025044652780849L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    270960436,
                    new BigIntegernumericArray2M
                    {
                        Id = 270960436,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5617177110171437653L),

new System.Numerics.BigInteger(1905142130861173469L),

new System.Numerics.BigInteger(1548746965273437008L),

new System.Numerics.BigInteger(4614358781725280053L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 2076560430,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    302933392,
                    new BigIntegernumericArray2M
                    {
                        Id = 302933392,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(388109706595115178L),

new System.Numerics.BigInteger(5610753262454131435L),

new System.Numerics.BigInteger(3771429800812004532L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    551097052,
                    new BigIntegernumericArray2M
                    {
                        Id = 551097052,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3358726987334664855L),

new System.Numerics.BigInteger(1563693458223875866L),

new System.Numerics.BigInteger(4568862100231555278L),

new System.Numerics.BigInteger(3512228423184538825L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1598764917,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

}
                        }

                    }
                );

                expected.Add(
                    639741758,
                    new BigIntegernumericArray2M
                    {
                        Id = 639741758,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7997080038965275373L),

new System.Numerics.BigInteger(3513000890053006236L),

new System.Numerics.BigInteger(7829551473148353883L),

new System.Numerics.BigInteger(1046606165057554038L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 679443223,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

}
                        }

                    }
                );

                expected.Add(
                    727024500,
                    new BigIntegernumericArray2M
                    {
                        Id = 727024500,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2367770282502363055L),

new System.Numerics.BigInteger(7415523726634051297L),

new System.Numerics.BigInteger(3349432232105772984L),

new System.Numerics.BigInteger(2380724208345022228L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    757932427,
                    new BigIntegernumericArray2M
                    {
                        Id = 757932427,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6293738943356192073L),

new System.Numerics.BigInteger(823122438178902566L),

new System.Numerics.BigInteger(5771665947362039708L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1358911903798518202L),

new System.Numerics.BigInteger(4196125725721268652L),

new System.Numerics.BigInteger(4388964499255988395L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1720130461,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    799428150,
                    new BigIntegernumericArray2M
                    {
                        Id = 799428150,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3715805737654602050L),

new System.Numerics.BigInteger(9062059990232576958L),

new System.Numerics.BigInteger(2328420139642418107L),

new System.Numerics.BigInteger(6695731212846079101L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8710627384603829169L),

new System.Numerics.BigInteger(8078375784890823128L),

new System.Numerics.BigInteger(5953815663684422939L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    862830099,
                    new BigIntegernumericArray2M
                    {
                        Id = 862830099,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6578577777482990190L),

new System.Numerics.BigInteger(1456302757925190382L),

new System.Numerics.BigInteger(1226103689422247203L),

new System.Numerics.BigInteger(7901408888287788949L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6142403399556484557L),

new System.Numerics.BigInteger(7900310366684279353L),

new System.Numerics.BigInteger(3814444672646505946L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    923222103,
                    new BigIntegernumericArray2M
                    {
                        Id = 923222103,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3699671119812945395L),

new System.Numerics.BigInteger(5602147479244755085L),

new System.Numerics.BigInteger(9147594091794754532L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5364705028243547882L),

new System.Numerics.BigInteger(7921413581697490772L),

new System.Numerics.BigInteger(6781752383081551016L),

new System.Numerics.BigInteger(2241822190513321989L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    939948092,
                    new BigIntegernumericArray2M
                    {
                        Id = 939948092,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7694981400987333814L),

new System.Numerics.BigInteger(5541481687306536652L),

new System.Numerics.BigInteger(978794594688216608L),

new System.Numerics.BigInteger(8147030791962190544L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1893596591,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1020188543,
                    new BigIntegernumericArray2M
                    {
                        Id = 1020188543,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1905814343599323237L),

new System.Numerics.BigInteger(4069983543369735556L),

new System.Numerics.BigInteger(6687983908299156284L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6336817352848434203L),

new System.Numerics.BigInteger(5024259737757992910L),

new System.Numerics.BigInteger(1293573156856398570L),

new System.Numerics.BigInteger(9017558288602906059L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1068832184,
                    new BigIntegernumericArray2M
                    {
                        Id = 1068832184,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7165217414963377123L),

new System.Numerics.BigInteger(2626718335520218109L),

new System.Numerics.BigInteger(4926416638541338112L),

new System.Numerics.BigInteger(5387364161426209020L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7750815814474317140L),

new System.Numerics.BigInteger(1844034408245249152L),

new System.Numerics.BigInteger(1955191491234792198L),

new System.Numerics.BigInteger(1214083856901435250L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 739693648,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1104169843,
                    new BigIntegernumericArray2M
                    {
                        Id = 1104169843,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2026444178543202885L),

new System.Numerics.BigInteger(2458787017607652447L),

new System.Numerics.BigInteger(6693730342879888221L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 551820850,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

}
                        }

                    }
                );

                expected.Add(
                    1300217034,
                    new BigIntegernumericArray2M
                    {
                        Id = 1300217034,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5318263558241213815L),

new System.Numerics.BigInteger(5351839984273482957L),

new System.Numerics.BigInteger(7888277948765087838L),

new System.Numerics.BigInteger(3909580336439627094L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1851199664,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1369411641,
                    new BigIntegernumericArray2M
                    {
                        Id = 1369411641,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1608701175172771101L),

new System.Numerics.BigInteger(1794415572747812693L),

new System.Numerics.BigInteger(6033632229356853072L),

new System.Numerics.BigInteger(3126482095995250627L),

},
                        NullableValue = null,

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1960725515,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

}
                        }

                    }
                );

                expected.Add(
                    1375955229,
                    new BigIntegernumericArray2M
                    {
                        Id = 1375955229,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5432071301186803904L),

new System.Numerics.BigInteger(794166050029313580L),

new System.Numerics.BigInteger(5993309134701787080L),

new System.Numerics.BigInteger(7611194661867458529L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1386603023,
                    new BigIntegernumericArray2M
                    {
                        Id = 1386603023,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7909718474806503704L),

new System.Numerics.BigInteger(2033085959756192546L),

new System.Numerics.BigInteger(4542666707932597154L),

new System.Numerics.BigInteger(8176254321989412492L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4101976528934784677L),

new System.Numerics.BigInteger(8512172066157745863L),

new System.Numerics.BigInteger(416269697718109518L),

new System.Numerics.BigInteger(3466060608717589917L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1548532340,
                    new BigIntegernumericArray2M
                    {
                        Id = 1548532340,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8266404950593677055L),

new System.Numerics.BigInteger(4350503590502298577L),

new System.Numerics.BigInteger(7139880734275732191L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1553344984,
                    new BigIntegernumericArray2M
                    {
                        Id = 1553344984,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3895744990669239083L),

new System.Numerics.BigInteger(24854048917483795L),

new System.Numerics.BigInteger(751623775333421574L),

new System.Numerics.BigInteger(1448174477814422589L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2401368408419754650L),

new System.Numerics.BigInteger(8962998951198369546L),

new System.Numerics.BigInteger(6602119945486258493L),

new System.Numerics.BigInteger(5501020081838479423L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 591085358,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

}
                        }

                    }
                );

                expected.Add(
                    1740136444,
                    new BigIntegernumericArray2M
                    {
                        Id = 1740136444,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(315823560314824292L),

new System.Numerics.BigInteger(7212992567163034150L),

new System.Numerics.BigInteger(208874442826159641L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7793132793856343630L),

new System.Numerics.BigInteger(2577835780181397135L),

new System.Numerics.BigInteger(6784212153400710790L),

new System.Numerics.BigInteger(4109478043739878585L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1780379271,
                    new BigIntegernumericArray2M
                    {
                        Id = 1780379271,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1131771775906533523L),

new System.Numerics.BigInteger(7528792746019432941L),

new System.Numerics.BigInteger(4738352460408841185L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(239536737214942006L),

new System.Numerics.BigInteger(7970601032686244625L),

new System.Numerics.BigInteger(7009816382155098195L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1863080736,
                    new BigIntegernumericArray2M
                    {
                        Id = 1863080736,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2737432382058845446L),

new System.Numerics.BigInteger(1266556933335938249L),

new System.Numerics.BigInteger(9031878028912073371L),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1870821351,
                    new BigIntegernumericArray2M
                    {
                        Id = 1870821351,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7902969964663716495L),

new System.Numerics.BigInteger(4197255418194735329L),

new System.Numerics.BigInteger(28424949874988431L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2144224473994697286L),

new System.Numerics.BigInteger(87467929770974049L),

new System.Numerics.BigInteger(1069416152458517503L),

new System.Numerics.BigInteger(2850513351879879469L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1920492346,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

}
                        }

                    }
                );

                expected.Add(
                    1918251500,
                    new BigIntegernumericArray2M
                    {
                        Id = 1918251500,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7088373354786043989L),

new System.Numerics.BigInteger(5916915450794692259L),

new System.Numerics.BigInteger(8838515308505248714L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5165245706973828859L),

new System.Numerics.BigInteger(6094061405295667103L),

new System.Numerics.BigInteger(892494171018402878L),

new System.Numerics.BigInteger(3043602518798803225L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1198060843,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1925555227,
                    new BigIntegernumericArray2M
                    {
                        Id = 1925555227,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3938557165138057194L),

new System.Numerics.BigInteger(5707494964798844813L),

new System.Numerics.BigInteger(6028862480124470860L),

new System.Numerics.BigInteger(1113948886176653069L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(7281294020598771141L),

new System.Numerics.BigInteger(3329350172867847132L),

new System.Numerics.BigInteger(270404500475758814L),

new System.Numerics.BigInteger(342764547484946593L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1815709177,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1992288868,
                    new BigIntegernumericArray2M
                    {
                        Id = 1992288868,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(3237049592676955718L),

new System.Numerics.BigInteger(7882862826115456624L),

new System.Numerics.BigInteger(193141890211385332L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(448761800470056038L),

new System.Numerics.BigInteger(7730406847745518648L),

new System.Numerics.BigInteger(7609616295559118734L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 2054679547,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

}
                        }

                    }
                );

                expected.Add(
                    2021284279,
                    new BigIntegernumericArray2M
                    {
                        Id = 2021284279,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(3576662678800941153L),

new System.Numerics.BigInteger(8565298041708473114L),

new System.Numerics.BigInteger(6703555915395040153L),

new System.Numerics.BigInteger(5128189755578866090L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6413180278101875414L),

new System.Numerics.BigInteger(7582583699103404423L),

new System.Numerics.BigInteger(7570528347278279562L),

new System.Numerics.BigInteger(4085757915983567284L),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2069934029,
                    new BigIntegernumericArray2M
                    {
                        Id = 2069934029,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9138450285564376511L),

new System.Numerics.BigInteger(9087908524818659407L),

new System.Numerics.BigInteger(8730289545009417685L),

new System.Numerics.BigInteger(5429303541057272274L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1139042372091598329L),

new System.Numerics.BigInteger(4023787005198763725L),

new System.Numerics.BigInteger(5999429438875870883L),

},

                        ModelInner = new BigIntegernumericArray2MI
                        {
                            Id = 1458296791,
                            Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Numerics.BigInteger>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_bigintegernumericarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(BigIntegernumericArray2MI),
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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray2MI>(15);

                expected.Add(
                    551820850,
                    new BigIntegernumericArray2MI
                    {
                        Id = 551820850,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

}
                    }
                );

                expected.Add(
                    591085358,
                    new BigIntegernumericArray2MI
                    {
                        Id = 591085358,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

}
                    }
                );

                expected.Add(
                    679443223,
                    new BigIntegernumericArray2MI
                    {
                        Id = 679443223,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

}
                    }
                );

                expected.Add(
                    739693648,
                    new BigIntegernumericArray2MI
                    {
                        Id = 739693648,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1198060843,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1198060843,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1458296791,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1458296791,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

}
                    }
                );

                expected.Add(
                    1598764917,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1598764917,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

}
                    }
                );

                expected.Add(
                    1720130461,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1720130461,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1815709177,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1815709177,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1851199664,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1851199664,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1893596591,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1893596591,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1920492346,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1920492346,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

}
                    }
                );

                expected.Add(
                    1960725515,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1960725515,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

}
                    }
                );

                expected.Add(
                    2054679547,
                    new BigIntegernumericArray2MI
                    {
                        Id = 2054679547,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

}
                    }
                );

                expected.Add(
                    2076560430,
                    new BigIntegernumericArray2MI
                    {
                        Id = 2076560430,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

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

                var expected = new Dictionary<System.Int32,BigIntegernumericArray2MI>(15);

                expected.Add(
                    551820850,
                    new BigIntegernumericArray2MI
                    {
                        Id = 551820850,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(4973437678487891434L),

new System.Numerics.BigInteger(7687070309778779579L),

new System.Numerics.BigInteger(6856173767625045540L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(1316437137372553243L),

new System.Numerics.BigInteger(4987719660940422191L),

new System.Numerics.BigInteger(5655335469066036875L),

}
                    }
                );

                expected.Add(
                    591085358,
                    new BigIntegernumericArray2MI
                    {
                        Id = 591085358,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(4533146152008697271L),

new System.Numerics.BigInteger(2687273936529376013L),

new System.Numerics.BigInteger(7301051274892814188L),

new System.Numerics.BigInteger(8170212738837334947L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1120847589657913234L),

new System.Numerics.BigInteger(2024433925139936252L),

new System.Numerics.BigInteger(1820382294198930063L),

new System.Numerics.BigInteger(6488553388282578180L),

}
                    }
                );

                expected.Add(
                    679443223,
                    new BigIntegernumericArray2MI
                    {
                        Id = 679443223,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6061896966174944341L),

new System.Numerics.BigInteger(8835303620658506968L),

new System.Numerics.BigInteger(2249529922184170351L),

new System.Numerics.BigInteger(6964333908056182521L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(50765521006915186L),

new System.Numerics.BigInteger(863408629879468138L),

new System.Numerics.BigInteger(7774881280604015002L),

}
                    }
                );

                expected.Add(
                    739693648,
                    new BigIntegernumericArray2MI
                    {
                        Id = 739693648,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5934445779697406075L),

new System.Numerics.BigInteger(822805388166253654L),

new System.Numerics.BigInteger(4748385437189294551L),

new System.Numerics.BigInteger(8701166021310067040L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1198060843,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1198060843,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2525707423777637183L),

new System.Numerics.BigInteger(3445237235520593035L),

new System.Numerics.BigInteger(4827806560133490540L),

new System.Numerics.BigInteger(5222204803321502526L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1458296791,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1458296791,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(621108975629630613L),

new System.Numerics.BigInteger(3367293208516493457L),

new System.Numerics.BigInteger(6584742335402670343L),

new System.Numerics.BigInteger(9223248998835892216L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(6759943918925148127L),

new System.Numerics.BigInteger(2820415424905429288L),

new System.Numerics.BigInteger(8271030754093012105L),

new System.Numerics.BigInteger(4079241122645703201L),

}
                    }
                );

                expected.Add(
                    1598764917,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1598764917,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2104319285046031920L),

new System.Numerics.BigInteger(6408036870715892279L),

new System.Numerics.BigInteger(4594139986135610127L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(332953076413261571L),

new System.Numerics.BigInteger(3435787089846156289L),

new System.Numerics.BigInteger(6153448456532067552L),

new System.Numerics.BigInteger(5118731038444961445L),

}
                    }
                );

                expected.Add(
                    1720130461,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1720130461,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(8494662043036519357L),

new System.Numerics.BigInteger(5821866222925590567L),

new System.Numerics.BigInteger(5815080352760478086L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1815709177,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1815709177,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(5756336045947923205L),

new System.Numerics.BigInteger(6737087073222124186L),

new System.Numerics.BigInteger(8755588047828202708L),

new System.Numerics.BigInteger(943355168063931587L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1851199664,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1851199664,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(2647926323662380043L),

new System.Numerics.BigInteger(3125851773659113669L),

new System.Numerics.BigInteger(8748262997951115433L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1893596591,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1893596591,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(715247811048377468L),

new System.Numerics.BigInteger(7909854286374507306L),

new System.Numerics.BigInteger(2640085573511129324L),

new System.Numerics.BigInteger(7842018889362923197L),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1920492346,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1920492346,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(9139682757975781468L),

new System.Numerics.BigInteger(634849722071110166L),

new System.Numerics.BigInteger(5628516917685899124L),

new System.Numerics.BigInteger(8577853882017628121L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(1405628222345751326L),

new System.Numerics.BigInteger(7141858036933112632L),

new System.Numerics.BigInteger(5337537943322143595L),

new System.Numerics.BigInteger(1142542603596769234L),

}
                    }
                );

                expected.Add(
                    1960725515,
                    new BigIntegernumericArray2MI
                    {
                        Id = 1960725515,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6363029603179823031L),

new System.Numerics.BigInteger(1750171758825694407L),

new System.Numerics.BigInteger(720567560873292763L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(4)
{
new System.Numerics.BigInteger(2458157200708203315L),

new System.Numerics.BigInteger(7392079828277901092L),

new System.Numerics.BigInteger(799065584510271187L),

new System.Numerics.BigInteger(7646151392254602444L),

}
                    }
                );

                expected.Add(
                    2054679547,
                    new BigIntegernumericArray2MI
                    {
                        Id = 2054679547,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(6994158141143938669L),

new System.Numerics.BigInteger(2013567523730226692L),

new System.Numerics.BigInteger(1863770574090855982L),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(7425685552207873153L),

new System.Numerics.BigInteger(6712880672964708558L),

new System.Numerics.BigInteger(162540130905147568L),

}
                    }
                );

                expected.Add(
                    2076560430,
                    new BigIntegernumericArray2MI
                    {
                        Id = 2076560430,
                        Value = 
new System.Collections.Generic.List<System.Numerics.BigInteger>(3)
{
new System.Numerics.BigInteger(686213582121567536L),

new System.Numerics.BigInteger(1303464226965800602L),

new System.Numerics.BigInteger(5107195895789037526L),

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

