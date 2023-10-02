

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
    internal partial interface IGuidListuuidArray
    {
    }
    
    internal partial class GuidListuuidArray : IGuidListuuidArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            asPartInterface: typeof(IGuidListuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                )
            ]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2mi(
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
            queryMapType: typeof(GuiduuidArray2MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, 214746660, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidArray)this).InsertModelInner(connection, 975961188, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, 59919729, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidArray)this).InsertModelInnerAsync(connection, 1078931846, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

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

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, 1885049552, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

}, null);
                Assert.That(id, Is.EqualTo(1885049552));

                id =  ((IGuidListuuidArray)this).InsertModelInnerReturning(connection, 44345862, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

}, null);
                Assert.That(id, Is.EqualTo(44345862));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 557953877, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

});
                Assert.That(id, Is.EqualTo(557953877));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 38066526, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

}, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

});
                Assert.That(id, Is.EqualTo(38066526));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 1836067282, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

});
                Assert.That(id, Is.EqualTo(1836067282));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 878658882, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

});
                Assert.That(id, Is.EqualTo(878658882));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 482219574, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

});
                Assert.That(id, Is.EqualTo(482219574));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 714151383, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

}, null);
                Assert.That(id, Is.EqualTo(714151383));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 308862982, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

}, null);
                Assert.That(id, Is.EqualTo(308862982));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 1518763270, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

}, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

});
                Assert.That(id, Is.EqualTo(1518763270));

                id = await ((IGuidListuuidArray)this).InsertModelInnerReturningAsync(connection, 1460776735, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

}, null);
                Assert.That(id, Is.EqualTo(1460776735));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
            asPartInterface: typeof(IGuidListuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
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

                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, 1037163389, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidArray)this).InsertModel(connection, 359969579, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

}, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

}, 214746660);
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

                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, 324293842, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidArray)this).InsertModelAsync(connection, 25569613, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

}, null, 975961188);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray2m(
	id,
    value,
    nullablevalue,
    guiduuidarray2mi_id
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
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(GuiduuidArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray2mi_id", 
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
                List<GuiduuidArray2M> models = null;
                GuiduuidArray2M model = null;

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, 603916967, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, 1164200075, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

}, null, 59919729).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, 982795711, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IGuidListuuidArray)this).InsertModelReturning(connection, 1076887420, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

}, null, 1078931846).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray2M> models = null;
                GuiduuidArray2M model = null;

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 87085150, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1914176914, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

}, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

}, 1885049552).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 523089612, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1840519714, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

}, 44345862).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1183907634, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1758559188, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

}, null, 557953877).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 258134496, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1631317749, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

}, 38066526).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1840853992, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 78994350, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

}, null, 1836067282).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 249338593, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1725487336, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

}, 878658882).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 342771293, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

}, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1045310848, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

}, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

}, 482219574).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 2108697304, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

}, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 552907246, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

}, null, 714151383).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1962952735, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 623786870, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

}, null, 308862982).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1187254253, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1422332991, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

}, null, 1518763270).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1381988837, 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

}, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidListuuidArray)this).InsertModelReturningAsync(connection, 1724252604, 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

}, null, 1460776735).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(GuiduuidArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)
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
                var models =  ((IGuidListuuidArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25569613));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(975961188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
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
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
                var models = await ((IGuidListuuidArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25569613));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(975961188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
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
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
FROM public.guiduuidarray2m m
LEFT JOIN public.guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(GuiduuidArray2M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidArray)
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
                var models =  ((IGuidListuuidArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25569613));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(975961188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
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
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
                var models = await ((IGuidListuuidArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25569613));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(975961188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
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
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
                 using var cmd =  ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 25569613);
                var models =  ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(29));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
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
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
                await using var cmd = await ((IGuidListuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 1037163389);
                var models = await ((IGuidListuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(16));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
            asPartInterface: typeof(IGuidListuuidArray)
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
                 foreach(var batchResult in ((IGuidListuuidArray)this).DbConnectionSelectModelBatch(connection, 1187254253, 603916967))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(11));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
                        Assert.That(models, Has.Count.EqualTo(19));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
                await foreach(var batchResult in ((IGuidListuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 87085150, 1045310848))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(27));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
                        Assert.That(models, Has.Count.EqualTo(15));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
COPY public.binary_guiduuidarray2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
FROM public.binary_guiduuidarray2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
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

                var importCollection = new List<GuiduuidArray2MI>(7);

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 38066526,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

}
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 44345862,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 59919729,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

}
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 214746660,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 308862982,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 482219574,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

}
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 557953877,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

}
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(38066526));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(44345862));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(59919729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(214746660));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(308862982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(482219574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(557953877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                new GuiduuidArray2MI
                {
                    Id = 714151383,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 878658882,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

}
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 975961188,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

}
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 1078931846,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 1460776735,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 1518763270,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

}
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 1836067282,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

}
                });

                importCollection.Add(
                new GuiduuidArray2MI
                {
                    Id = 1885049552,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

},
                    NullableValue = null
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(38066526));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(44345862));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(59919729));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(214746660));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(308862982));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(482219574));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(557953877));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(714151383));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(878658882));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(975961188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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
                Assert.That(model.Id, Is.EqualTo(1078931846));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1460776735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1518763270));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1836067282));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(1885049552));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
COPY public.binary_guiduuidarray2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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
FROM public.binary_guiduuidarray2m m
LEFT JOIN public.binary_guiduuidarray2mi mi ON mi.id = m.guiduuidarray2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(GuiduuidArray2M),
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

                var importCollection = new List<GuiduuidArray2M>(15);

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 25569613,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 975961188
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 78994350,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 1836067282
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 87085150,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 249338593,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 258134496,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 324293842,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 342771293,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 359969579,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

},

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 214746660
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 523089612,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 552907246,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 714151383
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 603916967,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 623786870,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 308862982
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 982795711,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1037163389,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1045310848,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

},

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 482219574
                    }

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25569613));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(975961188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
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
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                new GuiduuidArray2M
                {
                    Id = 1076887420,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 1078931846
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1164200075,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 59919729
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1183907634,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1187254253,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1381988837,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1422332991,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 1518763270
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1631317749,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

},

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 38066526
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1724252604,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 1460776735
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1725487336,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

},

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 878658882
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1758559188,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 557953877
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1840519714,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

},

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 44345862
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1840853992,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1914176914,
                    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

},

                    ModelInner = new GuiduuidArray2MI 
                    {
                        Id = 1885049552
                    }

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 1962952735,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray2M
                {
                    Id = 2108697304,
                    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

},
                    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

},

                    ModelInner = null

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(25569613));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(975961188));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

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
                Assert.That(model.Id, Is.EqualTo(78994350));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1836067282));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

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
                Assert.That(model.Id, Is.EqualTo(87085150));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

};
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
                Assert.That(model.Id, Is.EqualTo(249338593));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(258134496));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(324293842));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(342771293));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

};
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
                Assert.That(model.Id, Is.EqualTo(359969579));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(214746660));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

};
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
                Assert.That(model.Id, Is.EqualTo(523089612));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(552907246));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(714151383));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

};
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
                Assert.That(model.Id, Is.EqualTo(603916967));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(623786870));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(308862982));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

};
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
                Assert.That(model.Id, Is.EqualTo(982795711));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

};
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
                Assert.That(model.Id, Is.EqualTo(1037163389));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1045310848));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(482219574));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

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
                Assert.That(model.Id, Is.EqualTo(1076887420));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1078931846));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

};
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
                Assert.That(model.Id, Is.EqualTo(1164200075));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(59919729));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

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
                Assert.That(model.Id, Is.EqualTo(1183907634));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1187254253));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1381988837));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

};
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
                Assert.That(model.Id, Is.EqualTo(1422332991));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1518763270));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

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
                Assert.That(model.Id, Is.EqualTo(1631317749));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(38066526));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

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
                Assert.That(model.Id, Is.EqualTo(1724252604));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1460776735));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

};
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
                Assert.That(model.Id, Is.EqualTo(1725487336));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(878658882));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

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
                Assert.That(model.Id, Is.EqualTo(1758559188));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(557953877));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

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
                Assert.That(model.Id, Is.EqualTo(1840519714));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(44345862));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

};
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
                Assert.That(model.Id, Is.EqualTo(1840853992));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

};
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
                Assert.That(model.Id, Is.EqualTo(1914176914));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1885049552));

                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

};
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
                Assert.That(model.Id, Is.EqualTo(1962952735));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(2108697304));
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

};
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
COPY public.binary_guiduuidarray2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(GuiduuidArray2M),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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

                var expected = new Dictionary<System.Int32,GuiduuidArray2M>(30);

                expected.Add(
                    25569613,
                    new GuiduuidArray2M
                    {
                        Id = 25569613,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 975961188,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

}
                        }

                    }
                );

                expected.Add(
                    78994350,
                    new GuiduuidArray2M
                    {
                        Id = 78994350,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1836067282,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

}
                        }

                    }
                );

                expected.Add(
                    87085150,
                    new GuiduuidArray2M
                    {
                        Id = 87085150,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    249338593,
                    new GuiduuidArray2M
                    {
                        Id = 249338593,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    258134496,
                    new GuiduuidArray2M
                    {
                        Id = 258134496,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    324293842,
                    new GuiduuidArray2M
                    {
                        Id = 324293842,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    342771293,
                    new GuiduuidArray2M
                    {
                        Id = 342771293,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    359969579,
                    new GuiduuidArray2M
                    {
                        Id = 359969579,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 214746660,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    523089612,
                    new GuiduuidArray2M
                    {
                        Id = 523089612,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    552907246,
                    new GuiduuidArray2M
                    {
                        Id = 552907246,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 714151383,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    603916967,
                    new GuiduuidArray2M
                    {
                        Id = 603916967,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    623786870,
                    new GuiduuidArray2M
                    {
                        Id = 623786870,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 308862982,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    982795711,
                    new GuiduuidArray2M
                    {
                        Id = 982795711,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1037163389,
                    new GuiduuidArray2M
                    {
                        Id = 1037163389,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045310848,
                    new GuiduuidArray2M
                    {
                        Id = 1045310848,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 482219574,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

}
                        }

                    }
                );

                expected.Add(
                    1076887420,
                    new GuiduuidArray2M
                    {
                        Id = 1076887420,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1078931846,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1164200075,
                    new GuiduuidArray2M
                    {
                        Id = 1164200075,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 59919729,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

}
                        }

                    }
                );

                expected.Add(
                    1183907634,
                    new GuiduuidArray2M
                    {
                        Id = 1183907634,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1187254253,
                    new GuiduuidArray2M
                    {
                        Id = 1187254253,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1381988837,
                    new GuiduuidArray2M
                    {
                        Id = 1381988837,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1422332991,
                    new GuiduuidArray2M
                    {
                        Id = 1422332991,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1518763270,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

}
                        }

                    }
                );

                expected.Add(
                    1631317749,
                    new GuiduuidArray2M
                    {
                        Id = 1631317749,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 38066526,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

}
                        }

                    }
                );

                expected.Add(
                    1724252604,
                    new GuiduuidArray2M
                    {
                        Id = 1724252604,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1460776735,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1725487336,
                    new GuiduuidArray2M
                    {
                        Id = 1725487336,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 878658882,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

}
                        }

                    }
                );

                expected.Add(
                    1758559188,
                    new GuiduuidArray2M
                    {
                        Id = 1758559188,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 557953877,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

}
                        }

                    }
                );

                expected.Add(
                    1840519714,
                    new GuiduuidArray2M
                    {
                        Id = 1840519714,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 44345862,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1840853992,
                    new GuiduuidArray2M
                    {
                        Id = 1840853992,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1914176914,
                    new GuiduuidArray2M
                    {
                        Id = 1914176914,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1885049552,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1962952735,
                    new GuiduuidArray2M
                    {
                        Id = 1962952735,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2108697304,
                    new GuiduuidArray2M
                    {
                        Id = 2108697304,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
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

                var expected = new Dictionary<System.Int32,GuiduuidArray2M>(30);

                expected.Add(
                    25569613,
                    new GuiduuidArray2M
                    {
                        Id = 25569613,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("ab825c32-5f24-4ade-b7c2-ed277e51fcb1"),

Guid.Parse("d4d59fad-7b10-444d-900a-e07b98549aff"),

Guid.Parse("b15ece5e-27cc-4fc5-8aa6-7d3c41f14f87"),

Guid.Parse("07f77e03-fa5a-4c84-b571-f7380d35f51b"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 975961188,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

}
                        }

                    }
                );

                expected.Add(
                    78994350,
                    new GuiduuidArray2M
                    {
                        Id = 78994350,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("94d9ed11-cc69-4c40-a1c8-71882367bc90"),

Guid.Parse("a7660442-72f4-46cc-b268-0b0172c2ff50"),

Guid.Parse("39df1fd5-ab7e-4c78-b399-ac968e84bcc3"),

Guid.Parse("2d9cabcd-1bc7-4268-9509-26642b274407"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1836067282,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

}
                        }

                    }
                );

                expected.Add(
                    87085150,
                    new GuiduuidArray2M
                    {
                        Id = 87085150,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("265a9b30-36e7-40e3-84ae-a61e92dd1890"),

Guid.Parse("0ed26603-6118-4b4d-9f6b-5371de189b79"),

Guid.Parse("92b394ca-2133-42fe-8754-0c80488a0936"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2502f9d-12ea-462f-a63e-94801e17a645"),

Guid.Parse("c959c1f4-eadf-41b4-9d26-cbbeeb0d7dba"),

Guid.Parse("604875c8-8118-435c-a1a9-b3c4fa411353"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    249338593,
                    new GuiduuidArray2M
                    {
                        Id = 249338593,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ccd744e0-5255-416b-b54e-16ff58652242"),

Guid.Parse("27e23749-4171-4610-8d7b-f7f3ba629a6c"),

Guid.Parse("68dbc32c-d7b4-4d56-9cd8-43890c5b08a4"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    258134496,
                    new GuiduuidArray2M
                    {
                        Id = 258134496,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("63ca74f1-1446-4513-b3a2-3edf97caac98"),

Guid.Parse("9aac0d56-987e-4ba7-a36d-c8d6a905fffd"),

Guid.Parse("5d989fe6-c1d5-49db-a4e4-96102510543b"),

Guid.Parse("4812d1ec-b924-4458-a24c-6317ade92e34"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    324293842,
                    new GuiduuidArray2M
                    {
                        Id = 324293842,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e1b826be-16c7-4bb7-856f-672ec1ec5aea"),

Guid.Parse("c64eeb40-15c0-4950-9b0b-bd460de5ae7b"),

Guid.Parse("80b28046-a7df-4b83-8212-154faf02e76b"),

Guid.Parse("df892df0-e0d7-429d-9772-f2cfdac02a9c"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    342771293,
                    new GuiduuidArray2M
                    {
                        Id = 342771293,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e69f1104-2c6e-4c68-9447-0cdf4fb502a1"),

Guid.Parse("2a7ff43f-3623-42e2-b3b1-982a22fa53b4"),

Guid.Parse("fdb5cb50-5f48-4952-abff-ca48c24d7965"),

Guid.Parse("b0b1c067-6a27-4a1f-959d-2679a3fae357"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eaae37db-cd12-4e84-ab76-8b34fd0f0ecf"),

Guid.Parse("eda0aa1c-4bc0-42d8-9dbf-6c64cbaf3c6d"),

Guid.Parse("4745bb9f-01e6-4de6-adc4-b3b1ea9befbf"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    359969579,
                    new GuiduuidArray2M
                    {
                        Id = 359969579,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bb877440-a819-4cb8-a49d-97fbc57adb6b"),

Guid.Parse("814ff37a-acb0-4370-897f-9c6901756ea9"),

Guid.Parse("2f44562a-256d-426e-8327-6d665103a898"),

Guid.Parse("d82ef3dd-5999-42ce-b6a6-aba1f70870b9"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fb049740-a3e4-40b2-afb2-dbb12216b462"),

Guid.Parse("2e9e2e91-771c-4458-94c4-ae524f17e529"),

Guid.Parse("95fb8d85-ae45-434c-b326-ca638d67c76c"),

Guid.Parse("0d37b4a2-7489-410d-b219-49077fd0baf1"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 214746660,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    523089612,
                    new GuiduuidArray2M
                    {
                        Id = 523089612,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2ccaa9bf-2174-472e-be97-afa7c4e40130"),

Guid.Parse("09e96d23-7b01-4c6d-8b6a-b981c0ec431c"),

Guid.Parse("2169cc4c-a3bc-4817-834d-cc2dda35e926"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    552907246,
                    new GuiduuidArray2M
                    {
                        Id = 552907246,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("edd3a979-7d3c-4492-a62d-9cb329d0984e"),

Guid.Parse("4f261e28-9252-4c6e-b9d4-2b3f69d94361"),

Guid.Parse("c75ba6a7-f089-4c3b-bd63-871a8c19a15f"),

Guid.Parse("1980f907-c9e8-4d75-8063-67f7ab39e4d6"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 714151383,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    603916967,
                    new GuiduuidArray2M
                    {
                        Id = 603916967,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2e14ab97-8b0c-4039-8229-9f72c104bb45"),

Guid.Parse("a91758dc-9f54-4ea2-86f3-054411be0bed"),

Guid.Parse("9707e7b1-741a-45d0-a900-8cb838db6c5b"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    623786870,
                    new GuiduuidArray2M
                    {
                        Id = 623786870,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1373f2e4-fbd7-4e00-a6cc-086eaf88eab9"),

Guid.Parse("1b98e7b5-55d0-4e44-8efe-fb8b6e5b0577"),

Guid.Parse("7d7939e4-95b0-4214-9229-185eec3aaec8"),

Guid.Parse("4c874633-f76c-4207-b47e-10e33a1eb2cd"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 308862982,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    982795711,
                    new GuiduuidArray2M
                    {
                        Id = 982795711,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("37763f51-974f-4d92-b44f-ef2c5788cc97"),

Guid.Parse("116713f1-bce3-412f-a919-a830da4a2d61"),

Guid.Parse("b58c1411-ad65-43b2-93eb-c40ab9cc6023"),

Guid.Parse("f44b1f1b-d8e6-4fb6-88ee-d26603d5d475"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2e69672-de45-4310-9092-8be05f990eb6"),

Guid.Parse("ea837f9b-64da-4d9f-bb15-ebbfc0630407"),

Guid.Parse("86f7c461-ca42-40dd-afe8-f0a357c3b3f7"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1037163389,
                    new GuiduuidArray2M
                    {
                        Id = 1037163389,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("adf69be9-87bc-4d3a-b76d-50e5047c1312"),

Guid.Parse("b8de2850-af72-4a11-a420-4322848bf824"),

Guid.Parse("89813ebd-6b96-4d52-b667-693ed0181514"),

Guid.Parse("7195b980-9863-44bb-a2d3-7f28963a2277"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("98920857-9caf-41d1-a24c-06fe9eb1a0a4"),

Guid.Parse("4b91de6f-817a-4f45-991a-4d0d358832b4"),

Guid.Parse("75f89f68-d442-4eaa-9808-a3c9996cfbb4"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1045310848,
                    new GuiduuidArray2M
                    {
                        Id = 1045310848,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d5190c2e-4405-4e7e-a0e1-402af61ece7c"),

Guid.Parse("884c1f56-6954-4da1-84e0-cbfe5db71f9e"),

Guid.Parse("b754f48a-f2ec-4592-8bea-f9e7182d0e7d"),

Guid.Parse("43e49591-e357-4e67-93b4-0ca349ea2b8a"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("728e5701-443d-4c57-a6a4-8b3a7149d1fa"),

Guid.Parse("172ffcf7-46c0-4016-8b48-633eb948fbe2"),

Guid.Parse("56589759-e55d-479d-8cb2-b6b1df2e4e1a"),

Guid.Parse("50becdd7-4b31-4435-aa39-b19db2732f23"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 482219574,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

}
                        }

                    }
                );

                expected.Add(
                    1076887420,
                    new GuiduuidArray2M
                    {
                        Id = 1076887420,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("2a83a34e-fafe-4d81-acfc-18c1be3fa615"),

Guid.Parse("5b487b25-d757-4767-b4da-ea1d9f5257bb"),

Guid.Parse("5924e558-f654-4067-8917-aad551ff891e"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1078931846,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1164200075,
                    new GuiduuidArray2M
                    {
                        Id = 1164200075,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b33f5c49-ccf7-4070-bd76-52129745d99c"),

Guid.Parse("ca952183-1465-478f-8188-6c80247292c6"),

Guid.Parse("f2872ef8-ee16-4f50-9aa2-186a61c1e988"),

Guid.Parse("fcd7c41a-e07e-40ba-b4f6-cc29ee46f37e"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 59919729,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

}
                        }

                    }
                );

                expected.Add(
                    1183907634,
                    new GuiduuidArray2M
                    {
                        Id = 1183907634,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("20b664e7-93be-4f86-beb9-d4b52d315754"),

Guid.Parse("925ce415-4ad3-45c1-8ef7-2656d490967c"),

Guid.Parse("46277383-3b2a-4909-b943-53b01cca8ad2"),

Guid.Parse("712d14d1-1abe-41b0-ae51-4fa2a81e114a"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1187254253,
                    new GuiduuidArray2M
                    {
                        Id = 1187254253,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4f601af3-2f2a-40c2-969a-cdc0e8f18456"),

Guid.Parse("4872e30d-f0c7-44f3-afa0-3beb68159701"),

Guid.Parse("b37d55d7-7f56-42eb-acce-9e4ba87018f9"),

Guid.Parse("3c495213-1886-4201-95c8-7793038122dc"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1381988837,
                    new GuiduuidArray2M
                    {
                        Id = 1381988837,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("08d9e242-88b0-4c26-aeee-3b33882cdc60"),

Guid.Parse("63153899-256b-434f-a69d-8dd89f5031a9"),

Guid.Parse("ea974fc3-f03a-473d-bd10-6e59cfd8e62d"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e96d34fd-5698-45cf-b8fc-e5ced60533d8"),

Guid.Parse("e0f52f5c-bf14-462a-945d-fc01c19d415a"),

Guid.Parse("f4248ca7-7845-484f-b469-a443a6c210d2"),

Guid.Parse("c252c404-9ca7-4446-8372-097649e4f3cd"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1422332991,
                    new GuiduuidArray2M
                    {
                        Id = 1422332991,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("92d8b180-7bb9-448e-974c-ebaef42ed7bf"),

Guid.Parse("19fae8fd-b723-4537-af1b-e07ec9980395"),

Guid.Parse("96fe6f3b-8fe0-435f-8f2c-70ac6b611c75"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1518763270,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

}
                        }

                    }
                );

                expected.Add(
                    1631317749,
                    new GuiduuidArray2M
                    {
                        Id = 1631317749,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("7a506976-8576-4ff4-b970-44c403b2e47f"),

Guid.Parse("60c31eeb-10b0-4f7e-975c-0abe7734fc63"),

Guid.Parse("1af9110e-5cbe-4487-8f9a-dceb7cf001f6"),

Guid.Parse("d66ade36-a77f-40f0-8f50-572afe6ba305"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4990e3b2-5ec2-4f69-9bc1-bb05d94c593b"),

Guid.Parse("ded85623-0f3d-4051-b7f0-d7157d88b93f"),

Guid.Parse("df14c3af-9381-49ef-b845-7546557627ae"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 38066526,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

}
                        }

                    }
                );

                expected.Add(
                    1724252604,
                    new GuiduuidArray2M
                    {
                        Id = 1724252604,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e5780bb5-ce3d-4cd9-8ed9-0e2085a8a89e"),

Guid.Parse("bc7fbc2d-9e97-482a-b873-d3d658135e52"),

Guid.Parse("d796d9de-3b71-4ddb-8635-2024c1ed9338"),

Guid.Parse("0e241116-4481-4384-aab3-8b88dc2118d4"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1460776735,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1725487336,
                    new GuiduuidArray2M
                    {
                        Id = 1725487336,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("26dc4e69-c43c-4672-99d8-261477782c24"),

Guid.Parse("e0042805-dae8-4963-be23-c3341dbb54e1"),

Guid.Parse("4bad9996-21be-4b77-8cb4-312d4e345bec"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64f84efb-8d49-43b5-a4a0-09384198831d"),

Guid.Parse("e2314e85-9f62-455c-b687-a4a31438e21b"),

Guid.Parse("8d35b0df-6a9f-4d99-ae94-95b42caad534"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 878658882,
                            Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

}
                        }

                    }
                );

                expected.Add(
                    1758559188,
                    new GuiduuidArray2M
                    {
                        Id = 1758559188,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be1b8b55-e764-44d4-8e7f-717a9d3057cc"),

Guid.Parse("a485aaaa-eec9-45d8-be0b-022bf169c725"),

Guid.Parse("dbb510f7-520d-4e4a-ae72-3239465de66e"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 557953877,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

},
                            NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

}
                        }

                    }
                );

                expected.Add(
                    1840519714,
                    new GuiduuidArray2M
                    {
                        Id = 1840519714,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fe56bf96-c20e-4ff5-9d56-3aaaf03d091e"),

Guid.Parse("b8c64691-4258-4407-9e47-05dfb4764e3f"),

Guid.Parse("42e4bd2f-b2fd-4b30-8e02-3e7230b54878"),

Guid.Parse("a4d1f262-4576-4a9c-8052-7c45c7a17b43"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ddd02cdb-d139-420c-a12c-6dd5249f0592"),

Guid.Parse("dc3de736-f139-4777-a469-3a32d45a6cca"),

Guid.Parse("d630c5e3-11ae-486f-99fe-8d42573ba413"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 44345862,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1840853992,
                    new GuiduuidArray2M
                    {
                        Id = 1840853992,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("35d3e4c9-7ebe-49bf-9efd-1f2baed9ae2e"),

Guid.Parse("a5f1aa7b-772e-4bfb-9bd4-1c3299cec797"),

Guid.Parse("e952af31-00d5-440b-b95a-aa08bfd58c99"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("71986aff-52b1-4a97-9c08-5f75b156bf1f"),

Guid.Parse("f23ae0a2-cadb-4b31-bf4c-5d9f7c987679"),

Guid.Parse("092ad1d2-01d5-4f3f-b9a6-1119abdee371"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1914176914,
                    new GuiduuidArray2M
                    {
                        Id = 1914176914,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b32159e9-75ef-4d2b-ba31-424305b2b476"),

Guid.Parse("dcfa56b8-f606-4f68-a9ae-4d1f28344d8c"),

Guid.Parse("154b31df-fbd2-4d57-ae1a-3849fcf5a90f"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bfd686f7-8042-4239-952a-a81d4fd0c64b"),

Guid.Parse("f06d7ab2-c7b3-4e45-a465-c657e410271c"),

Guid.Parse("bc9d3ceb-1276-4dc7-94c1-442367a87936"),

Guid.Parse("c0c74326-5abe-4933-aa72-1de373cce53f"),

},

                        ModelInner = new GuiduuidArray2MI
                        {
                            Id = 1885049552,
                            Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1962952735,
                    new GuiduuidArray2M
                    {
                        Id = 1962952735,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("108ef015-a471-4bca-a01f-dea28bd86719"),

Guid.Parse("ce55161f-5a8b-4d43-b62f-a9ab752789a3"),

Guid.Parse("af6a7648-fb00-4b8d-b74c-629ac5a0a8fc"),

Guid.Parse("1e487647-d0a2-4688-8477-42c8999aa595"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    2108697304,
                    new GuiduuidArray2M
                    {
                        Id = 2108697304,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e802dda2-94cc-4275-b2ee-dfa497aad9d7"),

Guid.Parse("8ab5e5b0-d579-4c41-97b8-d792a22fbfd9"),

Guid.Parse("5c09f245-8f58-465c-980c-f314073eab4e"),

Guid.Parse("c068e61b-8336-4044-9791-5dc5719c3ae4"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a3376d7b-9908-439e-b9cc-f51174551a15"),

Guid.Parse("c4fd0f37-87c9-4bb4-baa2-5c02cad81d28"),

Guid.Parse("fb737e5b-bfd9-46e4-a151-99d0da016e94"),

Guid.Parse("db9cceea-7ae4-45ef-adf0-e095678b4676"),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Collections.Generic.List<System.Guid>)default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(GuiduuidArray2MI),
            dbTypes:
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
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

                var expected = new Dictionary<System.Int32,GuiduuidArray2MI>(15);

                expected.Add(
                    38066526,
                    new GuiduuidArray2MI
                    {
                        Id = 38066526,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

}
                    }
                );

                expected.Add(
                    44345862,
                    new GuiduuidArray2MI
                    {
                        Id = 44345862,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    59919729,
                    new GuiduuidArray2MI
                    {
                        Id = 59919729,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

}
                    }
                );

                expected.Add(
                    214746660,
                    new GuiduuidArray2MI
                    {
                        Id = 214746660,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    308862982,
                    new GuiduuidArray2MI
                    {
                        Id = 308862982,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    482219574,
                    new GuiduuidArray2MI
                    {
                        Id = 482219574,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

}
                    }
                );

                expected.Add(
                    557953877,
                    new GuiduuidArray2MI
                    {
                        Id = 557953877,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

}
                    }
                );

                expected.Add(
                    714151383,
                    new GuiduuidArray2MI
                    {
                        Id = 714151383,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    878658882,
                    new GuiduuidArray2MI
                    {
                        Id = 878658882,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

}
                    }
                );

                expected.Add(
                    975961188,
                    new GuiduuidArray2MI
                    {
                        Id = 975961188,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

}
                    }
                );

                expected.Add(
                    1078931846,
                    new GuiduuidArray2MI
                    {
                        Id = 1078931846,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1460776735,
                    new GuiduuidArray2MI
                    {
                        Id = 1460776735,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1518763270,
                    new GuiduuidArray2MI
                    {
                        Id = 1518763270,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

}
                    }
                );

                expected.Add(
                    1836067282,
                    new GuiduuidArray2MI
                    {
                        Id = 1836067282,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

}
                    }
                );

                expected.Add(
                    1885049552,
                    new GuiduuidArray2MI
                    {
                        Id = 1885049552,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

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

                var expected = new Dictionary<System.Int32,GuiduuidArray2MI>(15);

                expected.Add(
                    38066526,
                    new GuiduuidArray2MI
                    {
                        Id = 38066526,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f623b4d6-024a-49dd-a31f-e3e3c39e8ea8"),

Guid.Parse("2f9f0846-f0b8-44fd-977b-9533c6706661"),

Guid.Parse("c1ca773a-20f0-4ddc-866c-ba70ca2e956f"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("41732a3e-e990-4d02-8b4e-94d8f71dc244"),

Guid.Parse("e990fa23-6e5d-4ef1-8ea5-e1af9dbf9a48"),

Guid.Parse("b375d6a3-92e7-430b-ac31-78ec2a89d2c0"),

Guid.Parse("aebab8b1-d95e-47a0-8276-84ca1e2d99cc"),

}
                    }
                );

                expected.Add(
                    44345862,
                    new GuiduuidArray2MI
                    {
                        Id = 44345862,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b0edde0f-fa60-49b3-a030-c4ad0162bac5"),

Guid.Parse("b18656c0-b4bb-4ec8-80c3-e5aa8f20a3df"),

Guid.Parse("845e94c2-4272-48d2-99a8-71cdb6d6f460"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    59919729,
                    new GuiduuidArray2MI
                    {
                        Id = 59919729,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("05fa019e-2001-4871-9a5f-fe1570e1a930"),

Guid.Parse("67c05786-6808-4146-aa96-9198e8f72b64"),

Guid.Parse("32a5eb1e-8285-4636-b058-717dc31727da"),

Guid.Parse("7635b4ad-d011-451c-8259-b35cb0003274"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5ab2dcd5-ecaf-470f-aeda-627a11fbc1bf"),

Guid.Parse("b2624a60-ef9e-4eeb-916a-0538b088837a"),

Guid.Parse("51a805a1-831d-41ac-8671-60dc94cab3db"),

}
                    }
                );

                expected.Add(
                    214746660,
                    new GuiduuidArray2MI
                    {
                        Id = 214746660,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("f3eb66c6-8d45-4e7e-a570-65f34d0650e2"),

Guid.Parse("7bfcd179-f9c8-4ebc-a2f6-f70f3de10189"),

Guid.Parse("5650c937-48d0-4b26-a9b3-8ffb14e3dca3"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    308862982,
                    new GuiduuidArray2MI
                    {
                        Id = 308862982,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("36b13700-c61a-45b9-8153-b6692fd90738"),

Guid.Parse("879094ea-46e2-4d81-9a5a-b619012c0b84"),

Guid.Parse("eaba74e5-bddc-4f38-854c-639453726e5b"),

Guid.Parse("a2251ddd-8d50-4b91-8538-456564757838"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    482219574,
                    new GuiduuidArray2MI
                    {
                        Id = 482219574,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a2a7a83e-6f9a-4f6c-bff3-469bbe28699a"),

Guid.Parse("cf574ef0-6d55-4f7a-a5b0-d28db7e250a9"),

Guid.Parse("4023fc3c-b8f9-4089-84ed-0f156455b48c"),

Guid.Parse("cc667eed-6af2-4d76-b4de-4e9a838a12b5"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99e4d81b-4136-43fd-b220-dc5297f302d4"),

Guid.Parse("db7f39d6-ad16-4cd9-a9ed-e662aa16d16d"),

Guid.Parse("8e8dec0a-2fa0-4409-a4b9-16e3a1249bf8"),

}
                    }
                );

                expected.Add(
                    557953877,
                    new GuiduuidArray2MI
                    {
                        Id = 557953877,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("853e599b-1c87-4303-9f28-d90fb2eff004"),

Guid.Parse("049d691d-4789-4cc5-a282-dfc1bf143108"),

Guid.Parse("881d76c8-fa15-44a2-8882-ea585f407c51"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e3154be4-a9a9-4c1c-9fef-559aba3aa1f0"),

Guid.Parse("8e34679e-8c41-49c5-9b37-f66002c8a97d"),

Guid.Parse("1c66b6a3-3871-44ea-9c8a-e3c0a8481909"),

}
                    }
                );

                expected.Add(
                    714151383,
                    new GuiduuidArray2MI
                    {
                        Id = 714151383,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b92c9bcb-5130-4e3b-a79a-53ab4acdd26a"),

Guid.Parse("b71c84f9-5114-4c20-822b-70a7174f2837"),

Guid.Parse("774692af-dcee-4c49-814d-207914f23f08"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    878658882,
                    new GuiduuidArray2MI
                    {
                        Id = 878658882,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("f25d5812-1fcf-44eb-8c86-c5b6f60466a8"),

Guid.Parse("61ae4d82-759f-4384-8b2a-f9f99e825960"),

Guid.Parse("7f672650-6087-4b55-92c0-1905ec1d5175"),

Guid.Parse("46b0531e-f385-433a-9440-ac0b494561c4"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("72ee988c-33f6-4882-abd2-27b0de060424"),

Guid.Parse("e5c629ad-6730-4bdf-a149-fdbab622e4ff"),

Guid.Parse("bbc4bdd3-45d7-413d-9fb4-873490277531"),

}
                    }
                );

                expected.Add(
                    975961188,
                    new GuiduuidArray2MI
                    {
                        Id = 975961188,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("5db157a7-daea-44b7-bf4e-0bf8a5372ea3"),

Guid.Parse("b79fe0fa-43ae-4d83-8ae6-4e942907ca80"),

Guid.Parse("5ea87802-b89b-45ee-97f8-84c139eb10ec"),

Guid.Parse("5745f930-0234-42db-858b-a4f1692857cf"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("7db1b6eb-15e1-4d92-bdac-7029a5b1d20a"),

Guid.Parse("644be5c9-cde9-4b82-a212-3d23587102a6"),

Guid.Parse("f3078040-36d3-4254-b1cc-6b99e6f3e52e"),

}
                    }
                );

                expected.Add(
                    1078931846,
                    new GuiduuidArray2MI
                    {
                        Id = 1078931846,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("27dfe9d4-1565-400b-92e4-753fd01ca486"),

Guid.Parse("a2d7551c-310c-4b29-8ed9-8eb25e556b32"),

Guid.Parse("d5a437c9-8187-4e64-bf61-b47c44f03bc2"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1460776735,
                    new GuiduuidArray2MI
                    {
                        Id = 1460776735,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c7c31f01-73e2-4774-80d0-c3f4660031a3"),

Guid.Parse("d679ee11-d550-4e47-8a55-7c3249214215"),

Guid.Parse("10159420-f651-43c2-93a2-a1372fc507a1"),

Guid.Parse("a20b1f73-0b2d-4bc4-a0c7-99569473afba"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1518763270,
                    new GuiduuidArray2MI
                    {
                        Id = 1518763270,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3e1ff278-d6cc-4bd2-9691-f946ffbe13c1"),

Guid.Parse("b87d2a9b-dfec-4c9c-ae11-568f210a7d7d"),

Guid.Parse("dd23e2cb-23ae-475a-a5cc-98ee6ebc54cc"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("878a6c2c-2376-454a-bc89-4cfafb402a57"),

Guid.Parse("1959eb80-94bf-4f8b-b820-f7b149780d79"),

Guid.Parse("ed9132c7-605d-4b9c-8507-e6de841e50a5"),

Guid.Parse("eefcee40-d38c-4dfc-9a06-24d1615cfdab"),

}
                    }
                );

                expected.Add(
                    1836067282,
                    new GuiduuidArray2MI
                    {
                        Id = 1836067282,
                        Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4aacaf75-3cdf-43d9-bd16-ffd025473243"),

Guid.Parse("6e5ee626-6b85-48f2-b5cb-dcfbc8f7003e"),

Guid.Parse("b86c0c7e-ed78-4863-b776-23cbf997f414"),

Guid.Parse("f9703fb9-7a75-4926-ae91-e74db533bee8"),

},
                        NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("e2acff51-d0b6-45b1-8a6e-9383c637901a"),

Guid.Parse("f8ad8cc2-141f-4573-9f68-56e2c7f4e8a1"),

Guid.Parse("993b7e26-179c-443d-887d-64df31a6a81d"),

}
                    }
                );

                expected.Add(
                    1885049552,
                    new GuiduuidArray2MI
                    {
                        Id = 1885049552,
                        Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("260f6690-34fd-414b-8058-9803126b131a"),

Guid.Parse("76fb3bad-03bc-49c1-9ad0-01a5409f9796"),

Guid.Parse("93f48988-dfb5-45c1-b3a3-78c456fbfa49"),

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

