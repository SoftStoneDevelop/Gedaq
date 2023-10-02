

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
    internal partial interface IGuidArrayuuidArray
    {
    }
    
    internal partial class GuidArrayuuidArray : IGuidArrayuuidArray
    {


#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1mi(
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
            asPartInterface: typeof(IGuidArrayuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
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
INSERT INTO public.guiduuidarray1mi(
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
            queryMapType: typeof(GuiduuidArray1MI),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
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

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, 64496896, 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidArrayuuidArray)this).InsertModelInner(connection, 1196427652, 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

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

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, 50658308, 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

}, 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

});
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelInnerAsync(connection, 1128413840, 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

}, 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, 498728949, 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

}, null);
                Assert.That(id, Is.EqualTo(498728949));

                id =  ((IGuidArrayuuidArray)this).InsertModelInnerReturning(connection, 1634127689, 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

}, 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

});
                Assert.That(id, Is.EqualTo(1634127689));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 1160343339, 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

}, null);
                Assert.That(id, Is.EqualTo(1160343339));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 1799644374, 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

}, 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

});
                Assert.That(id, Is.EqualTo(1799644374));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 2135495672, 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

}, 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

});
                Assert.That(id, Is.EqualTo(2135495672));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 1605073646, 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

}, 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

});
                Assert.That(id, Is.EqualTo(1605073646));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 605131793, 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

}, 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

});
                Assert.That(id, Is.EqualTo(605131793));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 996495644, 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

}, 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

});
                Assert.That(id, Is.EqualTo(996495644));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 1099821071, 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

}, null);
                Assert.That(id, Is.EqualTo(1099821071));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 2041618425, 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

}, 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

});
                Assert.That(id, Is.EqualTo(2041618425));

                id = await ((IGuidArrayuuidArray)this).InsertModelInnerReturningAsync(connection, 201074419, 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

}, null);
                Assert.That(id, Is.EqualTo(201074419));

            }
        }

        #endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
            asPartInterface: typeof(IGuidArrayuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray1mi_id", 
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

                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, 1427489974, 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

}, null, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidArrayuuidArray)this).InsertModel(connection, 785190128, 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

}, 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

}, 64496896);
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

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, 372800347, 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

}, 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

}, null);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidArrayuuidArray)this).InsertModelAsync(connection, 270311061, 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

}, 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

}, 1196427652);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;

                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, 587865271, 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

}, 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

}, null);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

}));

                nullable =  ((IGuidArrayuuidArray)this).ScalarInsertModelReturning(connection, 1351551845, 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

}, null, 50658308);

                Assert.That(nullable, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[] nullable = null;

                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, 1818126489, 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

}, null, null);

                Assert.That(nullable, Is.Null);

                nullable = await ((IGuidArrayuuidArray)this).ScalarInsertModelReturningAsync(connection, 505367916, 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

}, 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

}, 1128413840);

                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

}));

            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidarray1m(
	id,
    value,
    nullablevalue,
    guiduuidarray1mi_id
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
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapType: typeof(GuiduuidArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)
            ), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)
                ),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidarray1mi_id", 
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
                List<GuiduuidArray1M> models = null;
                GuiduuidArray1M model = null;

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, 1869233187, 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

}, 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

}, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, 224580890, 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

}, null, 498728949).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(224580890));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(498728949));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, 8617863, 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

}, null, null).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8617863));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models =  ((IGuidArrayuuidArray)this).InsertModelReturning(connection, 1574616461, 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

}, 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

}, 1634127689).ToList();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidArray1M> models = null;
                GuiduuidArray1M model = null;

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 832036530, 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

}, 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 2120470488, 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

}, null, 1160343339).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 1518324042, 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

}, 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 2140788835, 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

}, 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

}, 1799644374).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 1416134832, 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 658395008, 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

}, null, 2135495672).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 1198742116, 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 301882533, 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

}, null, 1605073646).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(301882533));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1605073646));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 843747970, 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 310541207, 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

}, 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

}, 605131793).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 1022152866, 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

}, 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 513117396, 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

}, null, 996495644).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 164861030, 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

}, null, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(164861030));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 1683279230, 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

}, null, 1099821071).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 1629048453, 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

}, 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 75730364, 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

}, null, 2041618425).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(75730364));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2041618425));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                Assert.That(model.ModelInner.NullableValue, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 296563722, 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

}, 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

}, null).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(296563722));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Null);

                models = await ((IGuidArrayuuidArray)this).InsertModelReturningAsync(connection, 1401689495, 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

}, null, 201074419).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(1));
                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapType: typeof(GuiduuidArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)
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
                var models =  ((IGuidArrayuuidArray)this).SelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8617863));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(75730364));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2041618425));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

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
                Assert.That(model.Id, Is.EqualTo(164861030));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(224580890));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(498728949));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(270311061));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1196427652));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

};
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
                Assert.That(model.Id, Is.EqualTo(296563722));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

};
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
                Assert.That(model.Id, Is.EqualTo(301882533));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1605073646));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

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
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(372800347));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

};
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
                Assert.That(model.Id, Is.EqualTo(505367916));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128413840));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                var models = await ((IGuidArrayuuidArray)this).SelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8617863));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(75730364));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2041618425));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

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
                Assert.That(model.Id, Is.EqualTo(164861030));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(224580890));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(498728949));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(270311061));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1196427652));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

};
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
                Assert.That(model.Id, Is.EqualTo(296563722));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

};
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
                Assert.That(model.Id, Is.EqualTo(301882533));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1605073646));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

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
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(372800347));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

};
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
                Assert.That(model.Id, Is.EqualTo(505367916));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128413840));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
FROM public.guiduuidarray1m m
LEFT JOIN public.guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapType: typeof(GuiduuidArray1M),
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidArrayuuidArray)
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
                var models =  ((IGuidArrayuuidArray)this).DbConnectionSelectModel(connection, 0).ToList();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8617863));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(75730364));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2041618425));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

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
                Assert.That(model.Id, Is.EqualTo(164861030));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(224580890));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(498728949));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(270311061));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1196427652));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

};
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
                Assert.That(model.Id, Is.EqualTo(296563722));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

};
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
                Assert.That(model.Id, Is.EqualTo(301882533));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1605073646));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

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
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(372800347));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

};
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
                Assert.That(model.Id, Is.EqualTo(505367916));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128413840));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                var models = await ((IGuidArrayuuidArray)this).DbConnectionSelectModelAsync(connection, 0).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8617863));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(75730364));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2041618425));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

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
                Assert.That(model.Id, Is.EqualTo(164861030));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(224580890));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(498728949));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(270311061));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1196427652));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

};
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
                Assert.That(model.Id, Is.EqualTo(296563722));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

};
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
                Assert.That(model.Id, Is.EqualTo(301882533));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1605073646));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

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
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(372800347));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

};
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
                Assert.That(model.Id, Is.EqualTo(505367916));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128413840));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                 using var cmd =  ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 301882533);
                var models =  ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommand(cmd).ToList();

                Assert.That(models, Has.Count.EqualTo(23));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(372800347));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

};
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
                Assert.That(model.Id, Is.EqualTo(505367916));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128413840));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                await using var cmd = await ((IGuidArrayuuidArray)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidArrayuuidArray)this).SetDbConnectionSelectModelParametrs(cmd, 1574616461);
                var models = await ((IGuidArrayuuidArray)this).ExecuteDbConnectionSelectModelCommandAsync(cmd).ToListAsync();

                Assert.That(models, Has.Count.EqualTo(6));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
            asPartInterface: typeof(IGuidArrayuuidArray)
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
                 foreach(var batchResult in ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatch(connection, 1022152866, 1198742116))
                {
                    if(++resultIndex == 1)
                    {
                        var models =  batchResult.ToList();

                        Assert.That(models, Has.Count.EqualTo(13));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                        Assert.That(models, Has.Count.EqualTo(12));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                await foreach(var batchResult in ((IGuidArrayuuidArray)this).DbConnectionSelectModelBatchAsync(connection, 785190128, 505367916))
                {
                    if(++resultIndex == 1)
                    {
                        var models = await batchResult.ToListAsync();

                        Assert.That(models, Has.Count.EqualTo(16));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                        Assert.That(models, Has.Count.EqualTo(20));

                        var model = models[0];
    
                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
COPY public.binary_guiduuidarray1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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
FROM public.binary_guiduuidarray1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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

                var importCollection = new List<GuiduuidArray1MI>(7);

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 50658308,
                    Value = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 64496896,
                    Value = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 201074419,
                    Value = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 498728949,
                    Value = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 605131793,
                    Value = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 996495644,
                    Value = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 1099821071,
                    Value = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

},
                    NullableValue = null
                });

                ImportModelInner(connection, importCollection);
                var models = SelectImportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(50658308));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(64496896));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(201074419));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(498728949));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(605131793));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(996495644));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(1099821071));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                new GuiduuidArray1MI
                {
                    Id = 1128413840,
                    Value = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 1160343339,
                    Value = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 1196427652,
                    Value = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

},
                    NullableValue = null
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 1605073646,
                    Value = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 1634127689,
                    Value = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 1799644374,
                    Value = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 2041618425,
                    Value = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

}
                });

                importCollection.Add(
                new GuiduuidArray1MI
                {
                    Id = 2135495672,
                    Value = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

}
                });

                await ImportModelInnerAsync(connection, importCollection);
                models = await SelectImportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(15));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(50658308));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(64496896));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(201074419));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(498728949));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(605131793));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(996495644));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(1099821071));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1128413840));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(1160343339));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(1196427652));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

};
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
                Assert.That(model.Id, Is.EqualTo(1605073646));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

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
                Assert.That(model.Id, Is.EqualTo(1634127689));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1799644374));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
                Assert.That(model.Id, Is.EqualTo(2041618425));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

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
                Assert.That(model.Id, Is.EqualTo(2135495672));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
COPY public.binary_guiduuidarray1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidarray1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidArray1M),
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
FROM public.binary_guiduuidarray1m m
LEFT JOIN public.binary_guiduuidarray1mi mi ON mi.id = m.guiduuidarray1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapType: typeof(GuiduuidArray1M),
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

                var importCollection = new List<GuiduuidArray1M>(15);

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 8617863,
                    Value = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 75730364,
                    Value = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 2041618425
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 164861030,
                    Value = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 224580890,
                    Value = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 498728949
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 270311061,
                    Value = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

},

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 1196427652
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 296563722,
                    Value = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 301882533,
                    Value = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 1605073646
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 310541207,
                    Value = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

},

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 605131793
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 372800347,
                    Value = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 505367916,
                    Value = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

},

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 1128413840
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 513117396,
                    Value = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 996495644
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 587865271,
                    Value = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 658395008,
                    Value = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 2135495672
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 785190128,
                    Value = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

},

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 64496896
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 832036530,
                    Value = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

},

                    ModelInner = null

                });

                ImportModel(connection, importCollection);
                var models = SelectImportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(importCollection.Count));

                var model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8617863));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(75730364));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2041618425));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

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
                Assert.That(model.Id, Is.EqualTo(164861030));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(224580890));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(498728949));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(270311061));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1196427652));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

};
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
                Assert.That(model.Id, Is.EqualTo(296563722));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

};
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
                Assert.That(model.Id, Is.EqualTo(301882533));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1605073646));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

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
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(372800347));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

};
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
                Assert.That(model.Id, Is.EqualTo(505367916));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128413840));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                new GuiduuidArray1M
                {
                    Id = 843747970,
                    Value = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1022152866,
                    Value = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1198742116,
                    Value = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1351551845,
                    Value = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 50658308
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1401689495,
                    Value = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 201074419
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1416134832,
                    Value = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1427489974,
                    Value = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1518324042,
                    Value = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1574616461,
                    Value = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

},

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 1634127689
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1629048453,
                    Value = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

},
                    NullableValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1683279230,
                    Value = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 1099821071
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1818126489,
                    Value = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

},
                    NullableValue = null,

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 1869233187,
                    Value = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

},

                    ModelInner = null

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 2120470488,
                    Value = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

},
                    NullableValue = null,

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 1160343339
                    }

                });

                importCollection.Add(
                new GuiduuidArray1M
                {
                    Id = 2140788835,
                    Value = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

},
                    NullableValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

},

                    ModelInner = new GuiduuidArray1MI 
                    {
                        Id = 1799644374
                    }

                });

                await ImportModelAsync(connection, importCollection);
                models = await SelectImportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(30));

                model = models[0];

                Assert.That(model, Is.Not.Null);
                Assert.That(model.Id, Is.EqualTo(8617863));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(75730364));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2041618425));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

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
                Assert.That(model.Id, Is.EqualTo(164861030));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(224580890));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(498728949));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

};
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
                Assert.That(model.Id, Is.EqualTo(270311061));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1196427652));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

};
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
                Assert.That(model.Id, Is.EqualTo(296563722));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

};
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
                Assert.That(model.Id, Is.EqualTo(301882533));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1605073646));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

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
                Assert.That(model.Id, Is.EqualTo(310541207));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(605131793));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

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
                Assert.That(model.Id, Is.EqualTo(372800347));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

};
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
                Assert.That(model.Id, Is.EqualTo(505367916));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1128413840));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

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
                Assert.That(model.Id, Is.EqualTo(513117396));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(996495644));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

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
                Assert.That(model.Id, Is.EqualTo(587865271));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

};
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
                Assert.That(model.Id, Is.EqualTo(658395008));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(2135495672));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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
                Assert.That(model.Id, Is.EqualTo(785190128));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(64496896));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

};
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
                Assert.That(model.Id, Is.EqualTo(832036530));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

};
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
                Assert.That(model.Id, Is.EqualTo(843747970));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1022152866));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

};
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
                Assert.That(model.Id, Is.EqualTo(1198742116));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1351551845));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(50658308));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

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
                Assert.That(model.Id, Is.EqualTo(1401689495));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(201074419));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1416134832));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1427489974));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1518324042));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

};
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
                Assert.That(model.Id, Is.EqualTo(1574616461));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1634127689));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

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
                Assert.That(model.Id, Is.EqualTo(1629048453));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

};
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
                Assert.That(model.Id, Is.EqualTo(1683279230));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1099821071));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

};
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
                Assert.That(model.Id, Is.EqualTo(1818126489));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
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
                Assert.That(model.Id, Is.EqualTo(1869233187));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

};
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
                Assert.That(model.Id, Is.EqualTo(2120470488));
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Null);

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1160343339));

                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

};
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
                Assert.That(model.Id, Is.EqualTo(2140788835));
                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

};
                    Assert.That(model.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

};
                    Assert.That(model.NullableValue.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.NullableValue[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner, Is.Not.Null);
                Assert.That(model.ModelInner.Id, Is.EqualTo(1799644374));

                {
                    var expectEnumerValue = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

};
                    Assert.That(model.ModelInner.Value.Count(), Is.EqualTo(expectEnumerValue.Count()));
                    for(int i = 0; i < expectEnumerValue.Count(); i++)
                    {
                        var expectItem = expectEnumerValue[i];
                        var haveItem = model.ModelInner.Value[i];
                        Assert.That(expectItem, Is.EqualTo(haveItem));
                    }
                }

                Assert.That(model.ModelInner.NullableValue, Is.Not.Null);
                {
                    var expectEnumerValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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
COPY public.binary_guiduuidarray1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidarray1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapType: typeof(GuiduuidArray1M),
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

                var expected = new Dictionary<System.Int32,GuiduuidArray1M>(30);

                expected.Add(
                    8617863,
                    new GuiduuidArray1M
                    {
                        Id = 8617863,
                        Value = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    75730364,
                    new GuiduuidArray1M
                    {
                        Id = 75730364,
                        Value = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 2041618425,
                            Value = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

}
                        }

                    }
                );

                expected.Add(
                    164861030,
                    new GuiduuidArray1M
                    {
                        Id = 164861030,
                        Value = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    224580890,
                    new GuiduuidArray1M
                    {
                        Id = 224580890,
                        Value = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 498728949,
                            Value = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    270311061,
                    new GuiduuidArray1M
                    {
                        Id = 270311061,
                        Value = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1196427652,
                            Value = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    296563722,
                    new GuiduuidArray1M
                    {
                        Id = 296563722,
                        Value = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    301882533,
                    new GuiduuidArray1M
                    {
                        Id = 301882533,
                        Value = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1605073646,
                            Value = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

}
                        }

                    }
                );

                expected.Add(
                    310541207,
                    new GuiduuidArray1M
                    {
                        Id = 310541207,
                        Value = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 605131793,
                            Value = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

}
                        }

                    }
                );

                expected.Add(
                    372800347,
                    new GuiduuidArray1M
                    {
                        Id = 372800347,
                        Value = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    505367916,
                    new GuiduuidArray1M
                    {
                        Id = 505367916,
                        Value = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1128413840,
                            Value = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

}
                        }

                    }
                );

                expected.Add(
                    513117396,
                    new GuiduuidArray1M
                    {
                        Id = 513117396,
                        Value = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 996495644,
                            Value = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

}
                        }

                    }
                );

                expected.Add(
                    587865271,
                    new GuiduuidArray1M
                    {
                        Id = 587865271,
                        Value = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    658395008,
                    new GuiduuidArray1M
                    {
                        Id = 658395008,
                        Value = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 2135495672,
                            Value = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

},
                            NullableValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

}
                        }

                    }
                );

                expected.Add(
                    785190128,
                    new GuiduuidArray1M
                    {
                        Id = 785190128,
                        Value = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 64496896,
                            Value = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    832036530,
                    new GuiduuidArray1M
                    {
                        Id = 832036530,
                        Value = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    843747970,
                    new GuiduuidArray1M
                    {
                        Id = 843747970,
                        Value = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1022152866,
                    new GuiduuidArray1M
                    {
                        Id = 1022152866,
                        Value = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1198742116,
                    new GuiduuidArray1M
                    {
                        Id = 1198742116,
                        Value = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1351551845,
                    new GuiduuidArray1M
                    {
                        Id = 1351551845,
                        Value = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 50658308,
                            Value = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

}
                        }

                    }
                );

                expected.Add(
                    1401689495,
                    new GuiduuidArray1M
                    {
                        Id = 1401689495,
                        Value = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 201074419,
                            Value = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1416134832,
                    new GuiduuidArray1M
                    {
                        Id = 1416134832,
                        Value = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1427489974,
                    new GuiduuidArray1M
                    {
                        Id = 1427489974,
                        Value = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1518324042,
                    new GuiduuidArray1M
                    {
                        Id = 1518324042,
                        Value = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1574616461,
                    new GuiduuidArray1M
                    {
                        Id = 1574616461,
                        Value = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1634127689,
                            Value = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

}
                        }

                    }
                );

                expected.Add(
                    1629048453,
                    new GuiduuidArray1M
                    {
                        Id = 1629048453,
                        Value = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1683279230,
                    new GuiduuidArray1M
                    {
                        Id = 1683279230,
                        Value = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1099821071,
                            Value = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1818126489,
                    new GuiduuidArray1M
                    {
                        Id = 1818126489,
                        Value = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1869233187,
                    new GuiduuidArray1M
                    {
                        Id = 1869233187,
                        Value = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2120470488,
                    new GuiduuidArray1M
                    {
                        Id = 2120470488,
                        Value = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1160343339,
                            Value = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2140788835,
                    new GuiduuidArray1M
                    {
                        Id = 2140788835,
                        Value = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1799644374,
                            Value = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

},
                            NullableValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
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

                var expected = new Dictionary<System.Int32,GuiduuidArray1M>(30);

                expected.Add(
                    8617863,
                    new GuiduuidArray1M
                    {
                        Id = 8617863,
                        Value = 
new System.Guid[3]
{
Guid.Parse("64e71222-d870-4ced-b044-ca1bf91ebf15"),

Guid.Parse("58b65610-87f9-4368-a823-3d252d8161f1"),

Guid.Parse("0bbec0d4-7c8b-44b8-820c-096f322d83da"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    75730364,
                    new GuiduuidArray1M
                    {
                        Id = 75730364,
                        Value = 
new System.Guid[3]
{
Guid.Parse("07fb1552-c4c0-42af-b4c6-d4d90d176fb9"),

Guid.Parse("33bad401-13a3-4230-9b2d-b193d286218e"),

Guid.Parse("a536247b-40cb-47e0-9523-1902c5208072"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 2041618425,
                            Value = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

}
                        }

                    }
                );

                expected.Add(
                    164861030,
                    new GuiduuidArray1M
                    {
                        Id = 164861030,
                        Value = 
new System.Guid[4]
{
Guid.Parse("032a55f0-d7e2-473b-9656-bc6084d42f7d"),

Guid.Parse("9481987d-f8b7-4c34-ab13-58b50b13f369"),

Guid.Parse("21d4d382-de8a-4679-bea0-383ed80ee778"),

Guid.Parse("8e402a0f-ff70-48fd-a6bd-9f50feda0608"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    224580890,
                    new GuiduuidArray1M
                    {
                        Id = 224580890,
                        Value = 
new System.Guid[4]
{
Guid.Parse("25c09705-cf20-4c70-a293-76b3fa00fa46"),

Guid.Parse("33cee5fa-b134-481e-9860-76dcdfc3a9f0"),

Guid.Parse("7cdbf7e6-c85a-43ec-babf-c77efdc1126c"),

Guid.Parse("5924e876-61eb-44e4-afef-b0f4cffcc2a7"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 498728949,
                            Value = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    270311061,
                    new GuiduuidArray1M
                    {
                        Id = 270311061,
                        Value = 
new System.Guid[4]
{
Guid.Parse("5bf526cb-077c-4d73-89fc-b4768b36913b"),

Guid.Parse("8181e519-d350-415e-bc0a-76804c36bb3c"),

Guid.Parse("3a765dce-97e3-4987-b9c1-44c733924760"),

Guid.Parse("88273e08-003b-451b-b54f-0b5845f4936d"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("60d86873-c270-47e1-8762-a7f6d58cd1bc"),

Guid.Parse("b32412e2-ae0f-4762-be30-788b5aa1c0a7"),

Guid.Parse("dcd8e7c9-5ba2-429a-9edf-77f39784dae4"),

Guid.Parse("63abdc78-d521-4767-b74d-58de35656d03"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1196427652,
                            Value = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    296563722,
                    new GuiduuidArray1M
                    {
                        Id = 296563722,
                        Value = 
new System.Guid[4]
{
Guid.Parse("999b3ae9-8873-4792-a905-a9f98b08dac6"),

Guid.Parse("cfe51800-b7a0-4541-babe-73b89f42fb00"),

Guid.Parse("8fa2d29e-f379-4631-acae-b308856bbb55"),

Guid.Parse("9fac7126-d823-4cd9-8d58-09480ca8175e"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("ba0b4bf8-48ed-4a15-96a0-e44d3980f4c1"),

Guid.Parse("f466ff7c-2103-4f71-85cd-8497148730bd"),

Guid.Parse("722557b6-1834-4277-8721-15b458713f7d"),

Guid.Parse("0ecceb83-db6e-4bca-88eb-4a5eefe7f7ac"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    301882533,
                    new GuiduuidArray1M
                    {
                        Id = 301882533,
                        Value = 
new System.Guid[3]
{
Guid.Parse("4d502ae9-e751-47ae-b6c1-83ff355ed213"),

Guid.Parse("4607640c-1d27-4c43-967c-19b791fa96fa"),

Guid.Parse("ed5836f6-0ecb-421e-9a65-606c0f22d98b"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1605073646,
                            Value = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

}
                        }

                    }
                );

                expected.Add(
                    310541207,
                    new GuiduuidArray1M
                    {
                        Id = 310541207,
                        Value = 
new System.Guid[4]
{
Guid.Parse("e7f66d19-da2a-4b3e-9b10-25d85adeaa0c"),

Guid.Parse("5f47869d-92ee-4a99-a63e-b0c3c8b0cb10"),

Guid.Parse("7ac0df4e-8858-4ecf-be59-a8b962444eaa"),

Guid.Parse("a9e191ef-1919-40f7-8cc7-9e47d7fc08d2"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("7ac9fcab-f1db-41cd-be7d-116a114d6c2c"),

Guid.Parse("5e6a698a-6be0-4276-8704-58566f3ee083"),

Guid.Parse("19369086-052f-41f8-8f4e-142cb1c86893"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 605131793,
                            Value = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

}
                        }

                    }
                );

                expected.Add(
                    372800347,
                    new GuiduuidArray1M
                    {
                        Id = 372800347,
                        Value = 
new System.Guid[4]
{
Guid.Parse("5b545891-d4ec-44a4-98f0-cbc765af794c"),

Guid.Parse("4e604fe2-b11f-4050-9ae8-7429f1b8e144"),

Guid.Parse("844c905c-8946-4ec0-8a65-285e93930690"),

Guid.Parse("26d3ec26-d070-452c-826c-1013e7f744f3"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("fc8641e5-d739-4bab-a417-e8221c417094"),

Guid.Parse("f1b779b2-9467-4842-bc4a-e77c8704cb2c"),

Guid.Parse("e090abd0-cf75-4426-a240-c27eb6ec9006"),

Guid.Parse("d1bed335-d31b-4d3c-bf28-bb7bf24fc03a"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    505367916,
                    new GuiduuidArray1M
                    {
                        Id = 505367916,
                        Value = 
new System.Guid[3]
{
Guid.Parse("ee64062b-0ec3-4588-9ef4-53ae3ede3366"),

Guid.Parse("7b5cbc5a-cba1-4b2e-afb8-36a74ec9de86"),

Guid.Parse("69eba531-45e4-4ae3-8c0f-313be6e6004e"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("0d9b86ba-0467-4b30-b9a0-a5cec613c2fa"),

Guid.Parse("cdf4393c-a997-4d66-b7f9-cbdacb0031a4"),

Guid.Parse("a91c1e74-f1c6-49d8-9c05-f108f5f66752"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1128413840,
                            Value = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

}
                        }

                    }
                );

                expected.Add(
                    513117396,
                    new GuiduuidArray1M
                    {
                        Id = 513117396,
                        Value = 
new System.Guid[4]
{
Guid.Parse("ca03cd02-9816-4a37-b5bf-da3e7ab8d7b4"),

Guid.Parse("a772ad6c-1019-45e9-b15f-52d1c3986634"),

Guid.Parse("0146eff4-cb9e-4fca-b7ca-156e52502392"),

Guid.Parse("a7af384d-fd17-4240-8c85-c0039ddea0d7"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 996495644,
                            Value = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

}
                        }

                    }
                );

                expected.Add(
                    587865271,
                    new GuiduuidArray1M
                    {
                        Id = 587865271,
                        Value = 
new System.Guid[3]
{
Guid.Parse("49892813-31e7-4eae-8e51-fa8a80f759dc"),

Guid.Parse("3106b1ec-559e-4649-afee-40eb7fdf1b98"),

Guid.Parse("8b878118-703f-41b4-9099-b325215d949a"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("9600e27a-e927-4526-b974-69d6757afc00"),

Guid.Parse("34f5e1c6-58ac-49a9-b380-1e89b3d96b1f"),

Guid.Parse("24a0b0df-3021-4097-a84a-ca23270a498f"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    658395008,
                    new GuiduuidArray1M
                    {
                        Id = 658395008,
                        Value = 
new System.Guid[4]
{
Guid.Parse("0fa164ff-48a7-4bd8-8246-721c046ba383"),

Guid.Parse("2caa7183-2f64-40c6-a677-34d567e6b4c5"),

Guid.Parse("cabd1fbf-3b91-42c8-ace2-efb11e0bd34f"),

Guid.Parse("64888e68-9067-4071-8a73-17411301b35c"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 2135495672,
                            Value = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

},
                            NullableValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

}
                        }

                    }
                );

                expected.Add(
                    785190128,
                    new GuiduuidArray1M
                    {
                        Id = 785190128,
                        Value = 
new System.Guid[4]
{
Guid.Parse("a33b0dab-68a9-4b79-a3dd-1da2e14a855b"),

Guid.Parse("ebb141e9-49be-49aa-a98a-aa987a2d9c24"),

Guid.Parse("bb887d22-6c1a-4f29-bca5-e1a993ed6fd2"),

Guid.Parse("d00bb3ef-9df1-47e3-a72b-119263e165e2"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("1e6919af-f499-4745-9a32-a46e406a0ef4"),

Guid.Parse("9339447c-0f22-4dc6-80ee-8542b55dc2bb"),

Guid.Parse("e32ea06f-2f7e-4c54-bce0-4b5e2cba7143"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 64496896,
                            Value = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    832036530,
                    new GuiduuidArray1M
                    {
                        Id = 832036530,
                        Value = 
new System.Guid[3]
{
Guid.Parse("fff8b868-bc78-4732-8531-583a08d98780"),

Guid.Parse("236c5afd-bdf8-4f39-8c7a-65b832427df7"),

Guid.Parse("0183a2d1-0368-4ef7-be52-fcb52b926d69"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("754934de-7b19-4595-88bb-4dcb0ba3e502"),

Guid.Parse("8af443b4-f503-4ec2-955d-3e6432f0ea49"),

Guid.Parse("561f54fc-6317-49a6-ba6d-600d0778db12"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    843747970,
                    new GuiduuidArray1M
                    {
                        Id = 843747970,
                        Value = 
new System.Guid[3]
{
Guid.Parse("7e3eed5d-fe3a-445d-bd71-c591ee3633fa"),

Guid.Parse("20270d9b-a33b-411d-9d5b-6c209b22feaa"),

Guid.Parse("7edc026e-83cf-420f-9679-4af628076177"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1022152866,
                    new GuiduuidArray1M
                    {
                        Id = 1022152866,
                        Value = 
new System.Guid[3]
{
Guid.Parse("9a34724a-f918-4be7-b916-3ff638e5ae21"),

Guid.Parse("a58748ab-c49e-4dd6-96f3-51f1a6d9e47a"),

Guid.Parse("f62b3f80-a63a-49ab-af38-45a19a95094f"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("5724436c-caaf-471e-a128-9131547fabec"),

Guid.Parse("1a92892d-bdae-4dc4-b452-bbab1b61c224"),

Guid.Parse("1c9b0f88-c21c-425b-a34d-b2d6934a7a61"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1198742116,
                    new GuiduuidArray1M
                    {
                        Id = 1198742116,
                        Value = 
new System.Guid[3]
{
Guid.Parse("7787addf-d079-417c-9753-6d83a21a896e"),

Guid.Parse("b64053b5-311e-409d-9a5a-0ad269ce0d6a"),

Guid.Parse("b375b7e5-9f0a-4603-b85c-0160abcc5462"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1351551845,
                    new GuiduuidArray1M
                    {
                        Id = 1351551845,
                        Value = 
new System.Guid[3]
{
Guid.Parse("8b36dc15-11ed-4bc2-9095-792e6a20024a"),

Guid.Parse("f8b81f75-97ca-4d01-a68e-8c250ac79285"),

Guid.Parse("ed571fc2-d36d-4941-a203-6dcec3c5876d"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 50658308,
                            Value = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

}
                        }

                    }
                );

                expected.Add(
                    1401689495,
                    new GuiduuidArray1M
                    {
                        Id = 1401689495,
                        Value = 
new System.Guid[4]
{
Guid.Parse("06693f10-b570-4a95-8658-a09d549aafac"),

Guid.Parse("41f28fdb-7d9e-4870-9165-071648548710"),

Guid.Parse("e6795212-b0e8-40cc-b357-9a3fa95c607a"),

Guid.Parse("d237d36e-9a56-437e-9afd-cdc90a64c9ff"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 201074419,
                            Value = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1416134832,
                    new GuiduuidArray1M
                    {
                        Id = 1416134832,
                        Value = 
new System.Guid[4]
{
Guid.Parse("a76af495-770a-4395-ac1c-e7d12c156acb"),

Guid.Parse("a275c49b-ae1b-442c-9c1f-65564a1cb6b5"),

Guid.Parse("faaf987a-2516-4e9e-9ae8-91fb2c8dcf8f"),

Guid.Parse("fda023a6-f679-4cd4-90ee-ae274992e5c3"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1427489974,
                    new GuiduuidArray1M
                    {
                        Id = 1427489974,
                        Value = 
new System.Guid[3]
{
Guid.Parse("7ea3def9-edc1-4bef-8f8d-497c1d85152b"),

Guid.Parse("d813b58a-7691-47ac-80ae-3f10281c919d"),

Guid.Parse("ac5613ce-87ae-49f8-ba3d-f06039979f8b"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1518324042,
                    new GuiduuidArray1M
                    {
                        Id = 1518324042,
                        Value = 
new System.Guid[4]
{
Guid.Parse("d7917370-71f2-43c2-802c-c142fab3fa74"),

Guid.Parse("21afb2c2-7076-4635-bdba-fa11757c6d4b"),

Guid.Parse("5f9b32ab-c7d6-4174-b4b9-d6001171491d"),

Guid.Parse("824c4d2c-d362-4ff4-8176-9c9f42943ea8"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("fe40d179-4468-4162-9e22-193beda705bf"),

Guid.Parse("0a630a94-31c0-40a1-b26c-820cd038966b"),

Guid.Parse("890739ff-3aa3-41ce-b557-bcf31171163e"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1574616461,
                    new GuiduuidArray1M
                    {
                        Id = 1574616461,
                        Value = 
new System.Guid[3]
{
Guid.Parse("a74d9f8b-55c8-47b5-8da7-ce344e50c3d1"),

Guid.Parse("0f328e85-630e-4db1-8ce8-b7866e4f5cce"),

Guid.Parse("f78c531a-0084-4440-aa9b-57e89644b3db"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("2691004b-2ecb-46b6-95b0-c5db81c91e08"),

Guid.Parse("c8adcacf-08fe-452f-8a7d-b299bf5c3cb7"),

Guid.Parse("c639b66d-4b96-44b8-a360-318e2652fec0"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1634127689,
                            Value = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

},
                            NullableValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

}
                        }

                    }
                );

                expected.Add(
                    1629048453,
                    new GuiduuidArray1M
                    {
                        Id = 1629048453,
                        Value = 
new System.Guid[4]
{
Guid.Parse("458b6852-793e-406e-bf1a-d0c97392e748"),

Guid.Parse("a4de5715-b682-4e45-9378-e26a3e1f8419"),

Guid.Parse("e4444541-8227-4d41-97b8-b5bb2ea90ed6"),

Guid.Parse("e14e7371-6ffa-4d2b-a798-bb040acb0221"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("4866e782-52c9-4177-b55b-bac2f449c1e7"),

Guid.Parse("ca043217-8c44-4684-a6cc-dc0a02265c61"),

Guid.Parse("7bcd6075-4ef4-4948-9cdf-53849e4c9391"),

Guid.Parse("19586887-8921-4445-99f8-8577bef71f01"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    1683279230,
                    new GuiduuidArray1M
                    {
                        Id = 1683279230,
                        Value = 
new System.Guid[3]
{
Guid.Parse("58477823-7a99-4902-b902-f09930f0a85f"),

Guid.Parse("efa36ddb-3ab4-49e1-b2b7-19d68f930a87"),

Guid.Parse("8674ea2c-2159-4ceb-9c34-da56b6da6879"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1099821071,
                            Value = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    1818126489,
                    new GuiduuidArray1M
                    {
                        Id = 1818126489,
                        Value = 
new System.Guid[4]
{
Guid.Parse("64b5b45b-d0c2-4900-996a-9d65b82d4f3a"),

Guid.Parse("7341d6ae-872e-4558-84f6-2663ce825a47"),

Guid.Parse("e9b7dc27-ea11-4900-82a7-b418850d0669"),

Guid.Parse("acf890bc-1b51-43ca-aeb9-140eaa2b9911"),

},
                        NullableValue = null,

                        ModelInner = null

                    }
                );

                expected.Add(
                    1869233187,
                    new GuiduuidArray1M
                    {
                        Id = 1869233187,
                        Value = 
new System.Guid[3]
{
Guid.Parse("f8e635ff-df63-47f6-a3e0-3d82cb90b76d"),

Guid.Parse("368e4de3-dc2a-4a8d-ae6a-9808a684e3f1"),

Guid.Parse("eb36f128-abaf-40bb-952e-68ea644a4c54"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("7c8039ab-6fa1-405c-b43a-7389f91cc9e6"),

Guid.Parse("146902d1-7fa3-4748-82bb-b10ecfd35c48"),

Guid.Parse("13a6b57b-2f94-4b68-b18c-d6d75dd3284c"),

},

                        ModelInner = null

                    }
                );

                expected.Add(
                    2120470488,
                    new GuiduuidArray1M
                    {
                        Id = 2120470488,
                        Value = 
new System.Guid[3]
{
Guid.Parse("44d69956-2ebf-40f7-9c2d-83d834ed40bf"),

Guid.Parse("b3879e40-36f9-4cbb-a633-26bec433eb7f"),

Guid.Parse("be3ca427-6aba-4675-a7eb-6e0ae239ec3d"),

},
                        NullableValue = null,

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1160343339,
                            Value = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

},
                            NullableValue = null
                        }

                    }
                );

                expected.Add(
                    2140788835,
                    new GuiduuidArray1M
                    {
                        Id = 2140788835,
                        Value = 
new System.Guid[4]
{
Guid.Parse("7db96b4f-72e2-48e7-8a7b-3c8b99776571"),

Guid.Parse("801c7dfe-9477-4673-bd3d-a9446443ef5e"),

Guid.Parse("7cb0cfb2-8032-4282-aef6-c19b079d4ae7"),

Guid.Parse("b3fc2d78-d0d2-465a-b626-34fff77f0c95"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("6497262d-0523-459d-a218-75e2b401480b"),

Guid.Parse("f191b28d-5ed3-4464-82c2-4f70261bfbdc"),

Guid.Parse("c715fdfb-3654-4d7a-9175-7e21c442f0d0"),

},

                        ModelInner = new GuiduuidArray1MI
                        {
                            Id = 1799644374,
                            Value = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

},
                            NullableValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

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

                    Assert.That(model.ModelInner.Value, Is.EqualTo((System.Guid[])default));
                    Assert.That(model.ModelInner.NullableValue, Is.Null);

                }


                }
            }
        }

        #endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidarray1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapType: typeof(GuiduuidArray1MI),
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

                var expected = new Dictionary<System.Int32,GuiduuidArray1MI>(15);

                expected.Add(
                    50658308,
                    new GuiduuidArray1MI
                    {
                        Id = 50658308,
                        Value = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

}
                    }
                );

                expected.Add(
                    64496896,
                    new GuiduuidArray1MI
                    {
                        Id = 64496896,
                        Value = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    201074419,
                    new GuiduuidArray1MI
                    {
                        Id = 201074419,
                        Value = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    498728949,
                    new GuiduuidArray1MI
                    {
                        Id = 498728949,
                        Value = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    605131793,
                    new GuiduuidArray1MI
                    {
                        Id = 605131793,
                        Value = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

}
                    }
                );

                expected.Add(
                    996495644,
                    new GuiduuidArray1MI
                    {
                        Id = 996495644,
                        Value = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

}
                    }
                );

                expected.Add(
                    1099821071,
                    new GuiduuidArray1MI
                    {
                        Id = 1099821071,
                        Value = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1128413840,
                    new GuiduuidArray1MI
                    {
                        Id = 1128413840,
                        Value = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

}
                    }
                );

                expected.Add(
                    1160343339,
                    new GuiduuidArray1MI
                    {
                        Id = 1160343339,
                        Value = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1196427652,
                    new GuiduuidArray1MI
                    {
                        Id = 1196427652,
                        Value = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1605073646,
                    new GuiduuidArray1MI
                    {
                        Id = 1605073646,
                        Value = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

}
                    }
                );

                expected.Add(
                    1634127689,
                    new GuiduuidArray1MI
                    {
                        Id = 1634127689,
                        Value = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

}
                    }
                );

                expected.Add(
                    1799644374,
                    new GuiduuidArray1MI
                    {
                        Id = 1799644374,
                        Value = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

}
                    }
                );

                expected.Add(
                    2041618425,
                    new GuiduuidArray1MI
                    {
                        Id = 2041618425,
                        Value = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

}
                    }
                );

                expected.Add(
                    2135495672,
                    new GuiduuidArray1MI
                    {
                        Id = 2135495672,
                        Value = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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

                var expected = new Dictionary<System.Int32,GuiduuidArray1MI>(15);

                expected.Add(
                    50658308,
                    new GuiduuidArray1MI
                    {
                        Id = 50658308,
                        Value = 
new System.Guid[4]
{
Guid.Parse("20d28b43-c129-4a62-b908-cfbaaa8eb267"),

Guid.Parse("e192558f-092e-4f7f-9af5-6e296544e4b5"),

Guid.Parse("09219aeb-49de-4725-94bc-4370820992eb"),

Guid.Parse("5a7195f7-e6c1-47ef-9bfa-e5e49fef344e"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("3865b62d-ee05-4a77-8eff-5bda7c7ee933"),

Guid.Parse("8362f831-8ef9-4e21-9b9b-a230db9c48bf"),

Guid.Parse("f5892e42-e87d-4f96-b223-d9003c624daa"),

Guid.Parse("3452339e-1c52-496a-a817-6b1509126d15"),

}
                    }
                );

                expected.Add(
                    64496896,
                    new GuiduuidArray1MI
                    {
                        Id = 64496896,
                        Value = 
new System.Guid[3]
{
Guid.Parse("8abed895-88e5-4029-b92b-d13d83a14480"),

Guid.Parse("d306cb1e-fd1b-4124-a9d3-3ae08ac4cfdf"),

Guid.Parse("c47aee37-735b-462d-a34a-80282c5b0bc3"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    201074419,
                    new GuiduuidArray1MI
                    {
                        Id = 201074419,
                        Value = 
new System.Guid[3]
{
Guid.Parse("07cfbfdf-1bc4-4ee4-9777-f6ca95f6be50"),

Guid.Parse("4b5e2733-6797-45a2-9810-20776409c893"),

Guid.Parse("6baf73bd-a000-414e-b105-8541c118f0b4"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    498728949,
                    new GuiduuidArray1MI
                    {
                        Id = 498728949,
                        Value = 
new System.Guid[4]
{
Guid.Parse("b18634b4-5b07-4b33-9ea0-5ffaa34c4b37"),

Guid.Parse("305efda4-af90-4b8a-a384-d5ea36c8b4d8"),

Guid.Parse("88a5a38c-f8c3-4eca-973b-da99c5d17ad2"),

Guid.Parse("34bccb00-1e40-43f0-98c3-c3d69741428d"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    605131793,
                    new GuiduuidArray1MI
                    {
                        Id = 605131793,
                        Value = 
new System.Guid[4]
{
Guid.Parse("453af7ac-274f-4178-b262-024d4090a3dc"),

Guid.Parse("186f9e4f-9f70-4af4-b233-22f860fdbd50"),

Guid.Parse("866233dd-1948-43f3-ae51-6465ecb5ebd5"),

Guid.Parse("8aa0e246-ff72-4874-afd8-579b6463a39b"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("b2f4f78a-a301-4ed3-a3dd-693513960825"),

Guid.Parse("8ef65b01-64ee-4891-a8b3-c55ce88d1f1e"),

Guid.Parse("2074a54e-be30-480a-8274-6d3449ad779f"),

Guid.Parse("7dfe8e85-b4c5-43e1-b05b-3cd386648145"),

}
                    }
                );

                expected.Add(
                    996495644,
                    new GuiduuidArray1MI
                    {
                        Id = 996495644,
                        Value = 
new System.Guid[4]
{
Guid.Parse("5768cdaf-deb3-4f58-9038-f96160a38ac1"),

Guid.Parse("299a8960-8f32-4ed3-92c3-20c418dc0e68"),

Guid.Parse("96dc0075-a5a9-4f62-985e-8ec92e62abb6"),

Guid.Parse("11e86a1e-7411-48a3-9bfe-c31c108e7b4b"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("f24eb8e0-eb72-4dd3-b4ef-eef0a7c4b8cf"),

Guid.Parse("e67039c9-0ebc-4ab2-8ba5-ef4da1f77e6f"),

Guid.Parse("c20bfabe-1088-4101-89e2-5e3870f1d249"),

Guid.Parse("84772721-afea-46a0-83a7-2c2ce6e0478d"),

}
                    }
                );

                expected.Add(
                    1099821071,
                    new GuiduuidArray1MI
                    {
                        Id = 1099821071,
                        Value = 
new System.Guid[3]
{
Guid.Parse("41e505bf-3f13-470f-bd06-6ae1cc806180"),

Guid.Parse("e3a8f47c-44d4-44f8-9ab5-11a349644b8c"),

Guid.Parse("a285f66f-b821-4c14-8471-ae4d1eb390d4"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1128413840,
                    new GuiduuidArray1MI
                    {
                        Id = 1128413840,
                        Value = 
new System.Guid[3]
{
Guid.Parse("67d913f4-f860-4978-954d-9f8a5cd5de39"),

Guid.Parse("4cd13c0b-af4d-46e7-ad17-e84d5418e1d1"),

Guid.Parse("acdee830-8868-411d-aeb7-8c843e649cf7"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("f91b54c3-a010-4b93-81b4-fdb27df6d4f3"),

Guid.Parse("702fb960-7102-4364-83b4-e8bec9770742"),

Guid.Parse("4658ad9d-9785-4e3b-a80d-31dace8c950e"),

Guid.Parse("150b4ebc-d5ca-48f1-bc18-74d3e1fa5f89"),

}
                    }
                );

                expected.Add(
                    1160343339,
                    new GuiduuidArray1MI
                    {
                        Id = 1160343339,
                        Value = 
new System.Guid[3]
{
Guid.Parse("bdead752-54d1-4db8-ad22-ffa4df98a810"),

Guid.Parse("5da18318-200b-4008-9615-400d8b8bfbb1"),

Guid.Parse("8a649e96-dd5e-4686-9ab9-7d61d48b7a4f"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1196427652,
                    new GuiduuidArray1MI
                    {
                        Id = 1196427652,
                        Value = 
new System.Guid[4]
{
Guid.Parse("fdc6c773-aa21-44ee-9e13-8c359ab37c8a"),

Guid.Parse("b1e86d2e-5328-47fd-83dd-196b8861d361"),

Guid.Parse("ee1a30aa-8f69-4603-85db-d0b307103342"),

Guid.Parse("6de9f0b1-613d-42a0-8f5a-19b26fdbf37c"),

},
                        NullableValue = null
                    }
                );

                expected.Add(
                    1605073646,
                    new GuiduuidArray1MI
                    {
                        Id = 1605073646,
                        Value = 
new System.Guid[3]
{
Guid.Parse("6d6dce6b-aa6b-4880-b84c-a00719dd7a0a"),

Guid.Parse("4621f3ad-718d-4c79-b57c-3622334cc05a"),

Guid.Parse("3a848262-9d14-41e1-aa88-f9fff9118e17"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("a13e374a-757d-45c1-80c0-042f7657952f"),

Guid.Parse("32a87bc2-c75d-4a3f-9854-c14c1729b709"),

Guid.Parse("0c886adc-332f-46e6-ba00-a500ecc48204"),

Guid.Parse("5c32eef6-d17c-4709-bcfb-395bb709975e"),

}
                    }
                );

                expected.Add(
                    1634127689,
                    new GuiduuidArray1MI
                    {
                        Id = 1634127689,
                        Value = 
new System.Guid[4]
{
Guid.Parse("2a61adc0-ecf7-41c8-b40e-2ce4911e4745"),

Guid.Parse("986c6e6f-fd4a-4de0-b4d2-3174072e4303"),

Guid.Parse("08ae2522-f13d-46ca-90e9-2a7aa2c7cd8a"),

Guid.Parse("76486033-9b4d-4b87-afbd-c69d40fc38d4"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("1e848ab0-b26f-4e13-a1eb-98989e7a6769"),

Guid.Parse("ec377020-17b0-424c-b432-9c902d0c1d64"),

Guid.Parse("321c9e70-5d7b-491f-ae88-ee2ac19028ce"),

Guid.Parse("33b5756e-29bb-4ac0-bf1c-e92a7171257c"),

}
                    }
                );

                expected.Add(
                    1799644374,
                    new GuiduuidArray1MI
                    {
                        Id = 1799644374,
                        Value = 
new System.Guid[4]
{
Guid.Parse("6285e0b8-6f99-46d6-b4a1-a6bf97e03702"),

Guid.Parse("a0f8138a-9008-490f-8783-799308fe75a6"),

Guid.Parse("8093e728-4206-4a6b-b8b4-7242f0c5e519"),

Guid.Parse("d366045f-ec2e-40b4-bab1-6b1fe5952cd3"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("740a53f7-cc9a-4505-b866-17fd154995eb"),

Guid.Parse("4fcebd8d-3b51-40d6-8343-a39028de734a"),

Guid.Parse("361b0ff0-a9f2-43b0-b084-d847b76e0656"),

}
                    }
                );

                expected.Add(
                    2041618425,
                    new GuiduuidArray1MI
                    {
                        Id = 2041618425,
                        Value = 
new System.Guid[4]
{
Guid.Parse("4d009b87-6241-4809-8309-f699a3e2a71d"),

Guid.Parse("ac145809-50ba-4b09-a768-0e12e79dba6f"),

Guid.Parse("0186ecbc-6f93-4628-a203-569358dfde2b"),

Guid.Parse("37577d20-1cd9-4587-9b34-8ecd203659f1"),

},
                        NullableValue = 
new System.Guid[4]
{
Guid.Parse("2658d78d-96b8-4909-978e-4ac146900b04"),

Guid.Parse("7dc06e9b-da24-428d-8ec0-ee54e173114d"),

Guid.Parse("792c26d7-931a-4f5c-bc1d-9c78e3614fbd"),

Guid.Parse("bb54afe1-59f4-40c8-9051-457daf3a8a0f"),

}
                    }
                );

                expected.Add(
                    2135495672,
                    new GuiduuidArray1MI
                    {
                        Id = 2135495672,
                        Value = 
new System.Guid[3]
{
Guid.Parse("a7166840-b185-476c-8695-60b21eebaf8a"),

Guid.Parse("0808a531-a4ec-477f-ac53-055c1bf0fef4"),

Guid.Parse("58f6fcdf-d403-478f-b323-6ec892fe6c60"),

},
                        NullableValue = 
new System.Guid[3]
{
Guid.Parse("88ee4567-d85b-490f-b1a0-3384f9e2da22"),

Guid.Parse("8dfa05a9-5d78-4023-bcb0-6fb4063d5a01"),

Guid.Parse("1fc0741d-c121-41af-be06-7a288427d8d2"),

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

