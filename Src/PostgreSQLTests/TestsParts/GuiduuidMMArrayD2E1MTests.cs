

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
    internal partial interface IGuidMArrayuuidMMArrayD2
    {
    }
    
    internal partial class GuidMArrayuuidMMArrayD2 : IGuidMArrayuuidMMArrayD2
    {


#region TestData

        private readonly GuiduuidMMArrayD2E1M[] _testData = new GuiduuidMMArrayD2E1M[]
        {
            new GuiduuidMMArrayD2E1M
{
    Id = 5,
    Value = 
new System.Guid[,] { { Guid.Parse("17de0e39-f9ff-4e06-a8bd-0ae49925c351"), Guid.Parse("11363015-707a-4190-a514-7ea5becfdefd"), }, { Guid.Parse("bda48fcc-228a-4d59-9b69-06b496ae9825"), Guid.Parse("57e7edd2-edc8-483c-851a-556f6a2ac987"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("d4ac4453-b946-4dd2-a40a-c0946dc92745"), Guid.Parse("b5a92d81-e443-47da-be36-39d1684235c9"), }, { Guid.Parse("cb487508-0f3b-460f-9a7d-85e301b406e2"), Guid.Parse("c3cada68-0d7f-47d3-a170-28a30e253579"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 9,
    Value = 
new System.Guid[,] { { Guid.Parse("42428fac-000a-41ef-92a7-ecb1339e117b"), Guid.Parse("054ea5d6-8864-4fd4-868e-7b0083565d77"), }, { Guid.Parse("4aec1349-686e-46bc-be53-ccbddedc0c92"), Guid.Parse("c1c50a61-11ab-4e4c-8ff7-9b5fcb1f6c0e"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("339ee2eb-a9db-447d-ae17-dec127dbd6e2"), Guid.Parse("aae022c1-0a2d-471e-9f1a-a792bf889357"), }, { Guid.Parse("c9d16eb5-c454-4332-a22e-fb2323207cf1"), Guid.Parse("49b8c498-04c3-4b38-9e6d-abc49947aa2f"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 29,
    Value = 
new System.Guid[,] { { Guid.Parse("3d3255f7-c1fa-4a31-9c1e-a5b935034759"), Guid.Parse("39496dc2-a6b1-47a8-8cc9-dcdbe8e42c7e"), }, { Guid.Parse("8d7af13e-1f0b-4280-89ea-c3266e3d43b7"), Guid.Parse("93b3b480-7621-495f-852b-ef3d3e932102"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("e09d61cc-29f9-40b8-bdbf-7f9b98919ae8"), Guid.Parse("fae46882-aabf-4297-a487-d3359f33855a"), }, { Guid.Parse("da657ced-e31c-44d6-92c2-c4bdd8916bfa"), Guid.Parse("cda67f64-e8b0-4b9a-be9e-4f4716480e73"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("242e9eec-523d-4b6c-a053-48e853eeccb1"), Guid.Parse("79f7e04e-a861-4477-bed9-ac2e3eaca6af"), }, { Guid.Parse("87279e51-fb05-4bba-bcc6-c1b3c414e6fe"), Guid.Parse("973fef34-7231-4983-8368-ab9f40494af2"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c49bea9b-dabd-4188-b66d-ba35e9589dbc"), Guid.Parse("bb9b9c11-5361-4f08-ac6f-d2ec25dc2b37"), }, { Guid.Parse("df70c70f-0ae0-44ce-9408-6e64a504b825"), Guid.Parse("0d5bd7c9-c0f5-4fc3-84f3-3981e9007094"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("9deaf83c-c404-4bcf-beb9-3942b85d9f3c"), Guid.Parse("2651a3c9-5e0f-40b1-9418-276d53cef60b"), }, { Guid.Parse("ada134d0-2d23-42ac-8124-3452e0377bbf"), Guid.Parse("5db1672b-3970-4905-8c85-1b768dd940ea"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("a056f328-46f8-48b9-b4a6-c7929b27af79"), Guid.Parse("0711738d-4796-4485-8186-9575c0f3b681"), }, { Guid.Parse("7f8fc847-5155-4282-a689-fe29d69bf24e"), Guid.Parse("64a0091f-63f4-4dec-b7d9-d59c879d15e3"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 14,
    Value = 
new System.Guid[,] { { Guid.Parse("d6a2f39f-f46a-47a3-9934-c964256e7790"), Guid.Parse("fc1ea50e-4949-4964-8b7c-762b7664c5cf"), }, { Guid.Parse("93dff989-e238-438f-817d-4358d8e27168"), Guid.Parse("1da79f58-5b4b-4696-9e03-17e94480a3ec"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4cf8117d-429a-4f0f-867b-f4b65a516567"), Guid.Parse("ca76c035-66e8-4049-8cba-c8c466a8b3be"), }, { Guid.Parse("f82fbeca-3375-44a9-9494-629569c30ea2"), Guid.Parse("55b0513f-c0c0-4b78-8683-ed2e2174cf2a"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 52,
    Value = 
new System.Guid[,] { { Guid.Parse("93199af1-9b2c-4c3e-b06d-6042c706e47a"), Guid.Parse("fe131557-5380-4d19-bf70-9f5400ff2679"), }, { Guid.Parse("9b14ae42-e331-4061-9c7d-8e27e2558b18"), Guid.Parse("773b8af3-0663-43c3-bea3-fc007a76d081"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6769189b-9206-4fd3-9af9-a29891d54e5f"), Guid.Parse("c8d4cffb-be87-4d59-9ca2-0ed06efe5f00"), }, { Guid.Parse("9e4c518b-39f9-4714-a7d9-126bdd2bd399"), Guid.Parse("5b423d51-11bb-4e3c-92ae-bc6404cb3ca8"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 56,
    Value = 
new System.Guid[,] { { Guid.Parse("6425d98a-db0a-48c5-a363-c4760ccc104c"), Guid.Parse("0b556983-baaa-40ea-8df3-67c61139ff40"), }, { Guid.Parse("7c446ce1-172a-42cd-b8ad-95f62f976448"), Guid.Parse("141557ac-d9b9-482f-82b4-bc7d860f15ee"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Guid[,] { { Guid.Parse("d2831c0d-e745-421a-b9a7-5e13e75b18cc"), Guid.Parse("dd85198c-fee1-47ff-85af-e1296a113598"), }, { Guid.Parse("8f9a12ae-5d52-437e-a67e-c60f2dca7eb1"), Guid.Parse("1ea5901e-b905-4e3e-bdff-678e6f64f3fb"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 60,
    Value = 
new System.Guid[,] { { Guid.Parse("22c58b19-797e-40d3-9d04-1532ad02325c"), Guid.Parse("b2a66136-8066-4216-9afe-432626ec20f6"), }, { Guid.Parse("15d6f92e-09fb-43da-90d2-ff565c027394"), Guid.Parse("608dcc0e-3255-4d08-b8c6-b957b703d1e0"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("35b59d15-5556-4295-9903-579962e2b6cc"), Guid.Parse("f2a22f2e-d2db-4300-911d-36eacc23caeb"), }, { Guid.Parse("e3c0ff0f-2585-4f77-b13c-bad1be4d9886"), Guid.Parse("95753b3f-4287-4833-9b8e-80601ebda96f"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 66,
    Value = 
new System.Guid[,] { { Guid.Parse("2664b7e1-b898-40cd-b844-c6e2fda33605"), Guid.Parse("9136b995-800a-4e71-94f8-a6e2ec5ce812"), }, { Guid.Parse("e4521039-e100-4914-bdc2-fd870a81d0e7"), Guid.Parse("aaa60fae-a6dd-4934-8a3a-02291ebc876c"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("52d2fa6b-45d8-4226-9f35-b0783086219c"), Guid.Parse("880ffb3f-25de-4deb-b802-4579ea3be7fc"), }, { Guid.Parse("d0b12730-242b-4328-b3b0-a25a7a4b9feb"), Guid.Parse("e6b753d9-78f5-4f19-a3b9-f36918b60f14"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c42ba27b-8f1b-4745-8f4a-1fa444bbf20d"), Guid.Parse("f4595ca6-732c-4deb-97e2-ea0b138f749a"), }, { Guid.Parse("7d629477-28f8-4505-b399-9dae46a08858"), Guid.Parse("51132ee1-c11c-44cf-981f-604651cd6d8d"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("263342b8-7a7e-4629-8bfb-fa4fc4ab18fb"), Guid.Parse("d58ab9cb-52e8-4793-9efd-cfb631bf1b5e"), }, { Guid.Parse("fa2befa3-4cf1-455d-a4ce-5fd2697d6b44"), Guid.Parse("ce23d176-b057-4e02-b43e-5ea544b2f252"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("4f64cda6-e928-42b5-ba7c-f6cd1ae6ea1e"), Guid.Parse("fe8c200c-6f51-4e52-b594-242c333c8302"), }, { Guid.Parse("56f54860-71fe-42b7-9b2a-610d808ded6e"), Guid.Parse("45e8e4e0-056c-423b-a972-86beba0f1d9a"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 31,
    Value = 
new System.Guid[,] { { Guid.Parse("2f143661-0db7-4d4a-b494-2741b5c65b92"), Guid.Parse("df146fdb-4641-49e6-bab4-a4d727466ed5"), }, { Guid.Parse("b3b38dfc-5789-4712-b3df-58ccd1f01882"), Guid.Parse("b2743fec-2c44-4ba4-adbe-6f5ea74d61d2"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("44c43229-57ed-4831-a242-fb46f72d7585"), Guid.Parse("17041fbb-0dc3-47c2-bdcc-1ce4985ca0eb"), }, { Guid.Parse("82bb6f0e-e66b-4173-8396-ac67aacd216d"), Guid.Parse("237357ba-31bd-4d11-a456-7d6358084935"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("042d6101-44b3-4e1b-9bc7-b21ff9892921"), Guid.Parse("0b151837-37f3-49b2-8730-10799ed329ac"), }, { Guid.Parse("cd0cd8d2-45c4-49f6-8d54-4deb6ed8b149"), Guid.Parse("4e71b5b8-7987-4029-80df-604eb158d1d4"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 82,
    Value = 
new System.Guid[,] { { Guid.Parse("043b0984-bb54-438f-b125-2aa2d1edfae6"), Guid.Parse("a766b690-8d7f-4a49-bb6a-2d0a6bfe86ef"), }, { Guid.Parse("a99b68b4-ab43-4665-b548-0b0f4a1c23d3"), Guid.Parse("dc801614-5ff5-43b8-9a44-a0f440571bbf"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 90,
    Value = 
new System.Guid[,] { { Guid.Parse("f0f1b7f0-93dc-4170-9590-be8cfab36beb"), Guid.Parse("d567e806-cb16-46bd-a7e7-f9258d46680e"), }, { Guid.Parse("7ae03e8d-e680-4cdd-a8bc-7196b989491d"), Guid.Parse("f485631c-e2a5-4021-a4eb-5dd79c5c5b7e"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 40,
    Value = 
new System.Guid[,] { { Guid.Parse("50139bc0-252c-418e-82f3-9b8a16e21f1d"), Guid.Parse("0d3d59b0-3b34-4696-8e7f-e50a3df7ee71"), }, { Guid.Parse("f7074a0b-0d1f-4fa5-afbb-38cd99376222"), Guid.Parse("64ac96c0-19ff-463b-ace2-4fa3d687b0bf"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("868877d0-cdd9-4c87-b731-2a1733d59a22"), Guid.Parse("32f1d37b-d947-4602-9374-48cd4b08b6ad"), }, { Guid.Parse("aa96ceff-f35b-4a3b-8bf3-9e902d714733"), Guid.Parse("dbf4f1ae-a1b7-4145-b879-d79fe48273ef"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c1cef7eb-23ff-40bf-96b1-6c99a746b563"), Guid.Parse("b703c0bb-62ed-4b04-b2de-8c0ce261d37e"), }, { Guid.Parse("3b4e40ff-020d-4b7c-bd8c-c2c4e4446a2b"), Guid.Parse("cae7b64d-5f61-438a-96c4-0b257c56d51a"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Guid[,] { { Guid.Parse("7fdfecf3-7114-46c6-8ad1-1dbefd4123ae"), Guid.Parse("88d5751f-770b-4fae-b9c3-6c6a42188889"), }, { Guid.Parse("753e0654-5839-43d0-8f10-545fa91fd708"), Guid.Parse("28ee1a05-3e81-4157-ae16-957c82a890d1"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("982cc3e4-8dff-4aff-bbb3-33ff29379871"), Guid.Parse("f15e1412-3341-4d18-b5a3-92a83a9a7676"), }, { Guid.Parse("3f535716-896a-42f4-8d77-48cf71fa85c4"), Guid.Parse("36237c17-144a-4b81-93b1-d335c08ef070"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("3928ccd0-df0a-4692-bc75-bee665d70ca0"), Guid.Parse("f914beed-253c-4915-8925-6d9e7067be37"), }, { Guid.Parse("2921c890-039b-4dab-b647-ec3737ea649c"), Guid.Parse("05c36b2c-9e6a-443c-bbd9-98fb0ec8e8e8"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 42,
    Value = 
new System.Guid[,] { { Guid.Parse("08af2ccf-09ef-4591-a694-67c2849ec960"), Guid.Parse("56e63ab9-16ea-43a3-a552-1d42591c1a12"), }, { Guid.Parse("d0eb053e-5a19-4663-9af1-3511f6cffcb5"), Guid.Parse("20ce6ae5-3122-4888-90c5-91340ebe8cdb"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b3cdad04-bcaa-4689-96b0-302efb097298"), Guid.Parse("8882a79b-d2eb-4a3f-83d6-0f012c0fd4b2"), }, { Guid.Parse("c16487e4-c42b-43ea-befb-ddb9b2dd05b1"), Guid.Parse("94bd4b08-3796-494a-a66f-aafe0f93043d"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("13f60882-45d0-4caa-95d6-ffeda4547995"), Guid.Parse("75fa6d14-3eb3-4df6-b851-3d4608c0e3bf"), }, { Guid.Parse("05c92e41-aecd-4a2a-a339-0c6dfeb8e629"), Guid.Parse("9e77b6a4-cb87-4adb-b89d-b2b071b62067"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 95,
    Value = 
new System.Guid[,] { { Guid.Parse("2af56f30-cc3f-409a-9ff9-0eb900399dfc"), Guid.Parse("630bfc81-c57c-42af-b12e-c9d43d22693b"), }, { Guid.Parse("221c0b67-b6ce-4aeb-9d5b-05d2ff666c87"), Guid.Parse("9458a69b-16bb-4328-9ec4-be2b210db5e3"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a94b8ad9-6ff4-42f8-a8a7-a1a03e48b88c"), Guid.Parse("e5404879-60ba-4afb-a0ab-cf2756a4cd8c"), }, { Guid.Parse("7902b57d-71dd-4b5a-adf9-2cef27c72866"), Guid.Parse("cdeb6e3d-008f-4693-ae00-28f4e41d0578"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 97,
    Value = 
new System.Guid[,] { { Guid.Parse("783e2975-5037-44cb-982f-9935da8ee2a0"), Guid.Parse("70248a79-1813-4dc4-8b06-a1887dc9b207"), }, { Guid.Parse("7dd18c8c-064f-49d2-b096-7cb053d2738f"), Guid.Parse("e6dd88ab-f088-4e28-b9f1-a7771f29e6fc"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("15a58511-aa7a-44cf-812d-d0bf8ba48804"), Guid.Parse("3b12fe17-7a0e-445d-aee1-92c8a4611df4"), }, { Guid.Parse("b10f31a4-6894-4d6a-a7f3-856b1b0b737d"), Guid.Parse("5e381bf4-578f-4e65-8c3e-05712c0dc9db"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("09f37a9b-a0c7-4576-b350-492d7a69dcae"), Guid.Parse("8f9c7ae7-1897-45fb-b7df-d591d532f1c8"), }, { Guid.Parse("13b691c1-2dd7-48da-b334-dfb1a9000b0e"), Guid.Parse("99e988d8-79d4-4414-8f6e-1ca109b26022"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("658c0b02-7c1b-41cc-a63d-7a8a10338ca8"), Guid.Parse("1a68de6d-17b9-4a9c-be72-34f6a6436757"), }, { Guid.Parse("aab1cd7d-8316-48ab-a86a-2a7a5eaa61f1"), Guid.Parse("764ed09d-c912-4998-9797-3b87634c9e7c"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 108,
    Value = 
new System.Guid[,] { { Guid.Parse("eefc359e-ff15-46cc-933e-f7541abeac2c"), Guid.Parse("dae0efc9-0d19-4305-b1ad-68316e37846c"), }, { Guid.Parse("40d621ad-61e1-4860-bae6-cf1df3a397a8"), Guid.Parse("412ff981-934a-4193-bc74-b77ee13c8baa"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 50,
    Value = 
new System.Guid[,] { { Guid.Parse("d6b5ed40-634d-465f-982e-4b25daf54a71"), Guid.Parse("82adf992-643b-4b5c-ae35-54b178e34519"), }, { Guid.Parse("cb1926ca-98bb-478a-97ec-d9407b9c8ff7"), Guid.Parse("7ae647b6-2f06-4021-b196-7ba0fe50d48f"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("85460bb3-244a-458b-888e-e0f408aa970b"), Guid.Parse("2fec4d3f-6aec-4959-b876-c669970bf9be"), }, { Guid.Parse("8c30d742-9a5d-4592-a32d-7d7149a96b41"), Guid.Parse("f5436ac5-4f2c-4a6d-8c86-185ad82fdbec"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("200b4c0d-be3b-4c0f-b40d-8cf0037157b1"), Guid.Parse("88c3b547-1be5-4ce3-82bb-e36a777c5441"), }, { Guid.Parse("75d07753-b751-4589-bfb7-d98d27363d67"), Guid.Parse("a3b85d89-0f32-4b19-ad58-ce358067e121"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Guid[,] { { Guid.Parse("7baba731-91a4-471c-8221-d3dc28b302a9"), Guid.Parse("a7f9a653-ab66-4732-81cb-7dce152fc733"), }, { Guid.Parse("9fec0e42-cc3e-48fb-951d-fefda1c0ebeb"), Guid.Parse("d87b3b17-b5ec-425e-b41e-679d52ae6aea"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 123,
    Value = 
new System.Guid[,] { { Guid.Parse("db7b699c-e136-4a8d-938f-32df7f92464b"), Guid.Parse("c1144cfe-1c8f-4168-810b-b835e4673804"), }, { Guid.Parse("7e763b76-5ee5-4247-b17f-36cabdcd5566"), Guid.Parse("62945986-c89e-4e94-b5b9-83c5a74c214c"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("204460c7-77ef-4661-ba6f-49cd7fa8afe5"), Guid.Parse("d0abf484-bf35-4694-b996-a86b4224f0c2"), }, { Guid.Parse("9f7939dd-3a90-4c52-8a12-8922f29fc77e"), Guid.Parse("0e5e42da-1aa8-4483-b089-827fd236a302"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("225b7760-c3b0-40af-8f19-4f47d38f3f5a"), Guid.Parse("f055af81-9e14-45c2-8c31-e372f25c9fdb"), }, { Guid.Parse("e3db06b5-0725-40f6-9f28-f20e0b720634"), Guid.Parse("ae3b9a09-1727-4779-9585-ad6d00c76c3b"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("95ea257c-bf9d-4d3c-bbff-6b07eb850014"), Guid.Parse("a11d3700-c185-4915-8db4-c07c92dbbf7b"), }, { Guid.Parse("7b907a80-e868-4d11-9bca-1503c94d74b5"), Guid.Parse("f1fabc28-2993-4f45-9514-c6d5432098c4"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("da900abe-b412-4c0e-9dd5-a7acd949dca9"), Guid.Parse("e40e4763-7dd3-4d7b-8915-c9b1da5d61a3"), }, { Guid.Parse("f1c95e6a-2773-42d8-9bde-8c4e3f9f8aa3"), Guid.Parse("076315cc-3fd6-4733-ab7c-8249488e26ee"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 138,
    Value = 
new System.Guid[,] { { Guid.Parse("925c8ba6-9516-4c62-a68c-0a60df3bc8f5"), Guid.Parse("deefeb58-f22d-471d-aba5-46a3b32f3aff"), }, { Guid.Parse("7b1fd7cb-dd4d-43ef-988a-08f4d5c5a145"), Guid.Parse("6790746b-7ab0-4c92-8100-181157f3251a"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 63,
    Value = 
new System.Guid[,] { { Guid.Parse("fc8d1823-ee96-4259-8de0-ae12d54f194e"), Guid.Parse("56974777-b677-4a0c-bfb8-662985f14637"), }, { Guid.Parse("b16ee392-5b06-4dfc-b7c7-881c04a7429f"), Guid.Parse("6f06785c-84d8-4de9-a861-4d7342bec399"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 145,
    Value = 
new System.Guid[,] { { Guid.Parse("2e6979c6-12d2-4d14-b082-a9c5b7f0e83d"), Guid.Parse("704ce61b-5d7c-4536-8282-9e3b1591b069"), }, { Guid.Parse("59d3d367-31ab-483d-ba1d-23e53a595f5b"), Guid.Parse("f7e56d43-aeee-420f-9279-7f27c7c10bf8"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("fd653a25-36d7-4733-8fe3-34f6b302f0c4"), Guid.Parse("d99b4178-5068-42de-8eac-a70ec7363e8b"), }, { Guid.Parse("dd0eb72e-a406-43d8-82b0-41c284efbd78"), Guid.Parse("2d915c52-2196-4b33-bcaf-912da305933d"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 148,
    Value = 
new System.Guid[,] { { Guid.Parse("0a20ab5a-1059-4c5a-b61b-714811da6883"), Guid.Parse("e2dc24f3-9365-45f1-a283-29502d48ffa1"), }, { Guid.Parse("8f3d0c0d-9f77-4e4a-8f69-51fd1d2b5420"), Guid.Parse("efb1cb31-9087-44c7-8446-2db48aa1dc6e"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("168c2ff3-e56e-4dc3-9eb9-b54c65e1b7eb"), Guid.Parse("232cbc27-fd1e-4710-a4b5-6f6d9c75ec02"), }, { Guid.Parse("e0117e04-d587-4609-89a6-1d85f71fcee3"), Guid.Parse("af09de22-67eb-4b76-a087-85e0e667f57a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2f1c57ed-8edf-4410-a48f-b28fcdca0ad2"), Guid.Parse("02d7449c-bde1-47d9-8564-4ba22b2ffe7a"), }, { Guid.Parse("22ecd135-f6e5-4a89-8070-8dd4a8090df5"), Guid.Parse("46b236cf-020b-45a6-9cec-a1bc81e4b3ae"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("578ffd57-5c3e-449d-8878-35d6700422dd"), Guid.Parse("eea28720-cc56-4385-9f60-8dc250a18072"), }, { Guid.Parse("ba6bbe44-d63b-4d78-917e-643a6c1b31bc"), Guid.Parse("10cfda64-bd49-4431-b310-0b72bb6b8265"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Guid[,] { { Guid.Parse("4dd4590c-ae9e-4bbe-a01a-e031b6bf5331"), Guid.Parse("0923e741-3c73-4927-8662-545566f9962a"), }, { Guid.Parse("9d37dbf8-5a1f-4ab3-a3dc-9e5a20a5e363"), Guid.Parse("9d6c2d07-ff08-430b-8ff2-790b86c02948"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("51e801fb-caf0-42c3-bf2f-81f5db3bc10f"), Guid.Parse("fe85d045-6cd1-4d5c-86ba-cc806880b993"), }, { Guid.Parse("dc52282a-f0fd-41d1-b93f-7b0c4d148357"), Guid.Parse("ab418242-061f-4294-bc11-5fe363e68581"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Guid[,] { { Guid.Parse("25b7a67b-672a-4827-8bbe-e6ebac36cb0e"), Guid.Parse("e8c6f0a7-4dc2-42e2-bd33-5c2d616d4d97"), }, { Guid.Parse("53ecf6f3-373f-4237-b768-9d73f5c16ff8"), Guid.Parse("f47fcc1f-640a-4b15-8df8-519c24915883"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 72,
    Value = 
new System.Guid[,] { { Guid.Parse("d0067a27-d7cc-44fa-8b54-ba553391fe4a"), Guid.Parse("2b39219a-8e0c-4773-bd8d-360f0a60b435"), }, { Guid.Parse("8b4ed749-8aa7-4fd1-a1f4-a6d687467f60"), Guid.Parse("2a543075-65d9-405c-8d76-f6aced189fe0"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("934054d1-9b07-4e98-a56a-d273a1e4c232"), Guid.Parse("3a8808a6-e25d-41f0-a16d-650be5b75112"), }, { Guid.Parse("ec4a8538-cba3-472f-bc20-df1ea0e17b49"), Guid.Parse("7d5af174-823b-4bc5-91e1-151c91b077f3"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 160,
    Value = 
new System.Guid[,] { { Guid.Parse("ffcf8a53-bfbd-4b77-af87-3ccd273897d3"), Guid.Parse("d380afbc-3e68-4470-ac23-bef165856746"), }, { Guid.Parse("2fcad727-91c2-46e1-8548-3fd06b0fe544"), Guid.Parse("f25d4b7a-f7b8-4f08-9b70-506485f30a6c"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("bd3e17cf-12f8-4fde-a927-d0691a987d61"), Guid.Parse("007511e9-e77c-416c-aa38-8c0f83553f2a"), }, { Guid.Parse("70a0d216-ea3b-47a3-bfd9-0b56d4526efe"), Guid.Parse("8117f22b-f01f-4461-b1b2-fbb5665b0949"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Guid[,] { { Guid.Parse("976082a3-3989-4968-8766-ad4421020974"), Guid.Parse("063848b5-917f-47fb-8b7c-22c9677d0e3b"), }, { Guid.Parse("e74faf7d-7fc9-4b0a-9d5c-698357d4b8db"), Guid.Parse("ac2b513b-409e-40d1-9b01-cdacfedb02f9"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("abc4b0f9-7dc3-4bd9-890a-2868b19d14fb"), Guid.Parse("06271cb0-56af-4bc4-a884-900dee4c95ff"), }, { Guid.Parse("04a0ac65-5f5c-4a08-b09c-6b6be9a553a2"), Guid.Parse("50062037-ce51-43a1-9058-6fe3d06c0e3a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f17f8ed7-9b6b-47e8-b380-d8e3d0062259"), Guid.Parse("e141ab16-4467-4369-ae01-2c21f06f66de"), }, { Guid.Parse("ef2934a8-4417-41b4-97f8-e445071169de"), Guid.Parse("34ab9fe2-98d7-4735-8c22-fae8503bec23"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 178,
    Value = 
new System.Guid[,] { { Guid.Parse("40a06689-26cb-4207-859c-dc28394caf50"), Guid.Parse("5d84cedb-cce2-4ada-8248-e5faa0931984"), }, { Guid.Parse("88acdfd2-472b-4cbd-9b41-ef8da5619ce8"), Guid.Parse("bae2b2a7-1dbe-40c3-a21b-27632054bf2c"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Guid[,] { { Guid.Parse("70059915-9a81-4309-9561-b9f190ba8b80"), Guid.Parse("a0fb5318-909b-4ea1-8aa5-cfa6dd64d74e"), }, { Guid.Parse("289e6cff-5fd3-4f25-9267-d35c5ec4139d"), Guid.Parse("35e7da0d-7112-43d9-9d98-f43f718b6d43"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("a47d6f16-a249-4b4d-87fa-2bc5585bb481"), Guid.Parse("bf6cc1cb-5a1d-4d07-a0e2-94615523f49f"), }, { Guid.Parse("292a0e57-ddad-4ee4-8f89-3b1cdb9cbc22"), Guid.Parse("f4ef0840-531a-4267-bbef-ee7592edd919"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 181,
    Value = 
new System.Guid[,] { { Guid.Parse("85448feb-95c9-47f8-b3a3-8fd542dfc2c5"), Guid.Parse("d385457f-822c-4b63-b86b-dac77a6e9f29"), }, { Guid.Parse("9e41f488-f5f7-40a4-8a34-e77dc15e3b96"), Guid.Parse("8e1d6acb-af0e-4d2e-975e-4c32c798c549"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 182,
    Value = 
new System.Guid[,] { { Guid.Parse("23c4aaf3-08de-40f1-b0ec-ad3610d78549"), Guid.Parse("8157f0c9-3398-49a6-b511-6b0334ce398b"), }, { Guid.Parse("c437bbca-9755-4807-a309-3a5e21770602"), Guid.Parse("f47c7872-a121-41c7-96ae-b3ae79cd4ef7"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 87,
    Value = 
new System.Guid[,] { { Guid.Parse("bc284bf1-a1df-4344-ac2c-c072954d62cc"), Guid.Parse("4f1ef475-904f-40cb-82f7-e5b4973e946a"), }, { Guid.Parse("0f863649-ca5d-4acb-bd1e-b9e90d19bbde"), Guid.Parse("55e97a75-14ce-4e63-879b-510f2bc129e5"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("92151fb4-d4b3-4073-80b6-7166cc047521"), Guid.Parse("61d52cc3-7ab6-4f1b-b64a-bd878fdb7b24"), }, { Guid.Parse("ae9774fa-fe23-4a98-94c1-3df81c74b691"), Guid.Parse("0d231fe4-bb37-41ff-b6ac-45c6c4904023"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 191,
    Value = 
new System.Guid[,] { { Guid.Parse("b426655a-9155-492c-b176-563fddc9e5c0"), Guid.Parse("250b2e85-2e98-4a98-8eb1-cd026ba6341f"), }, { Guid.Parse("c9a8bd2c-5bc9-4328-9040-696cd88e50da"), Guid.Parse("caab3adf-f478-45bb-8015-779564bf2265"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("542cd485-161a-4e36-be4b-dc5a3430f66f"), Guid.Parse("871398ba-178d-4b0b-b000-aec98328957b"), }, { Guid.Parse("f5260db1-c9c5-4263-bd29-3715f3767f79"), Guid.Parse("bd1fa038-1985-43e8-8a6c-98c81f1d7b0d"), }, },
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1mi(
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
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
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

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[11].ModelInner.Id));

            }
        }

        [Test, Order(0)]
        public async Task InsertModelInnerTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Int32 id = default;

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
)
VALUES (
    $1, 
    $2, 
    $3,
    $4
);
",
            methodName:"InsertModel",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
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
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidMArrayuuidMMArrayD2)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[4].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[4].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[4].NullableValue != null)
                    {
                        parameters[2].Value = _testData[4].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[4].ModelInner != null)
                    {
                        parameters[3].Value = _testData[4].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[5].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[5].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[5].NullableValue != null)
                    {
                        parameters[2].Value = _testData[5].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[5].ModelInner != null)
                    {
                        parameters[3].Value = _testData[5].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturning(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDynParTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[6].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[6].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[6].NullableValue != null)
                    {
                        parameters[2].Value = _testData[6].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[6].ModelInner != null)
                    {
                        parameters[3].Value = _testData[6].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("6769189b-9206-4fd3-9af9-a29891d54e5f"), Guid.Parse("c8d4cffb-be87-4d59-9ca2-0ed06efe5f00"), }, { Guid.Parse("9e4c518b-39f9-4714-a7d9-126bdd2bd399"), Guid.Parse("5b423d51-11bb-4e3c-92ae-bc6404cb3ca8"), }, }));
                {
                    var parameters = new NpgsqlParameter[4];
                    parameters[0] = new NpgsqlParameter<System.Int32>();
                    ((NpgsqlParameter<System.Int32>)parameters[0]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    ((NpgsqlParameter<System.Int32>)parameters[0]).TypedValue = _testData[7].Id;

                    parameters[1] = new NpgsqlParameter<System.Guid[,]>();
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    ((NpgsqlParameter<System.Guid[,]>)parameters[1]).TypedValue = _testData[7].Value;

                    parameters[2] = new NpgsqlParameter();
                    parameters[2].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(-2147483621);
                    if (_testData[7].NullableValue != null)
                    {
                        parameters[2].Value = _testData[7].NullableValue;
                    }
                    else
                    {
                        parameters[2].Value = System.DBNull.Value;
                    }

                    parameters[3] = new NpgsqlParameter();
                    parameters[3].NpgsqlDbType = (NpgsqlTypes.NpgsqlDbType)(9);
                    if (_testData[7].ModelInner != null)
                    {
                        parameters[3].Value = _testData[7].ModelInner.Id;
                    }
                    else
                    {
                        parameters[3].Value = System.DBNull.Value;
                    }

                    nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelDynParReturningAsync(connection, parameters);
                }
                Assert.That(nullable, Is.Null);
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidmmarrayd2e1m(
	id,
    value,
    nullablevalue,
    guiduuidmmarrayd2e1mi_id
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
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidmmarrayd2e1mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalar()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("35b59d15-5556-4295-9903-579962e2b6cc"), Guid.Parse("f2a22f2e-d2db-4300-911d-36eacc23caeb"), }, { Guid.Parse("e3c0ff0f-2585-4f77-b13c-bad1be4d9886"), Guid.Parse("95753b3f-4287-4833-9b8e-80601ebda96f"), }, }));
                nullable =  ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturning(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(nullable, Is.Null);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningScalarAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                System.Guid[,] nullable = null;
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(nullable, Is.Null);
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("042d6101-44b3-4e1b-9bc7-b21ff9892921"), Guid.Parse("0b151837-37f3-49b2-8730-10799ed329ac"), }, { Guid.Parse("cd0cd8d2-45c4-49f6-8d54-4deb6ed8b149"), Guid.Parse("4e71b5b8-7987-4029-80df-604eb158d1d4"), }, }));
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[13], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[14], true);
                models =  ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturning(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidMMArrayD2E1M> models = null;

                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidMArrayuuidMMArrayD2)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void MMDynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void DynQuerySelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.Npgsql.Attributes.DynamicParametr()]
        private void SelectModelDynParConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void MMDynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task MMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void DynQuerySelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.Npgsql.Attributes.Parametr(
            parametrType: typeof(System.Int32),
            position: 1,
            methodParametrName: "id",
            dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        private void SelectModelConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 73;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 95;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(18));
                Assert.That(secondItems2, Has.Count.EqualTo(18));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 108;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(26));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 13;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 93;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                Assert.That(firstItems2, Has.Count.EqualTo(33));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[32],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(20));
                Assert.That(secondItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 52;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 94;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(28));
                Assert.That(firstItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelDynParBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModelDynPar",
            position: 2)]
        private void DbConnectionDynQuerySelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 67;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 13;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 56;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 123;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 155;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 145;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 178;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                Assert.That(secondItems2, Has.Count.EqualTo(4));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModelDynPar",
            position: 2)]
        private void DbConnectionSTSelectModelDynParBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 38;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 67;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(24));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelDynParTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 138;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 114;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M), typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionMMDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTMMDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionMMDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionMMDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 123, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(13));
                Assert.That(firstItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 180, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var models2 = new List<FlatGuiduuidMMArrayD2E1M>();
                ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 90, query1, 160, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(6));
                Assert.That(secondItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var firstItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 97, query1, 52, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(17));
                Assert.That(firstItems2, Has.Count.EqualTo(17));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionDynQuerySelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 2)]
        private void DbConnectionSTDynQuerySelectModelBatchConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionDynQuerySelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionDynQuerySelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionMMDynQuerySelectModel",
            position: 2)]
        private void DbConnectionDynQuerySelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 145, query1, 108, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 56, query1, 169, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                Assert.That(secondItems2, Has.Count.EqualTo(5));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 38, query1, 160, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(30));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(6));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionDynQuerySelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var query2 = @"
SELECT
    m.id AS item1id,
    m.value AS item1value,
    m.nullablevalue AS item1nullablevalue,
    m.id AS item2id,
    m.value AS item2value,
    m.nullablevalue AS item2nullablevalue
FROM public.guiduuidmmarrayd2e1m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems1 = new List<FlatGuiduuidMMArrayD2E1M>();
                var secondItems2 = new List<FlatGuiduuidMMArrayD2E1M>();
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 94, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(19));
                Assert.That(secondItems2, Has.Count.EqualTo(19));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[34], false);
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
FROM public.guiduuidmmarrayd2e1m m
LEFT JOIN public.guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.Parametr(
            parametrType: typeof(System.Int32), 
            parametrName: "id", 
            methodParametrName: "id", 
            dbType: (System.Data.DbType)(11))]
        private void DbConnectionSelectModelConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 1),
Gedaq.DbConnection.Attributes.BatchPart(
            methodName: "DbConnectionSelectModel",
            position: 2)]
        private void DbConnectionSTSelectModelBatchConfig()
        {
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = await((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 180, 66))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(25));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidMMArrayD2E1M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionSTSelectModelBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 114, 181))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(2));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                await using var cmd = await ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 169);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(5));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 21);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(32));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[3], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[4], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[5], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[6], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[7], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[8], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[9], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[10], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[11], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[12], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[13], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[14], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[15], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[16], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[17], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[18], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[34], false);
            }
        }

#endregion

#region BinaryImportModelInner

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(1)]
        public  void DynQueryWAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(3)]
        public  void DynQueryImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MI),
            dbTypes: 
            new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            },
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(5)]
        public  void WAImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidMMArrayD2E1MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: 
@"
SELECT
    mi.nullablevalue,
    mi.id,
    mi.value
FROM public.binary_guiduuidmmarrayd2e1mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidMMArrayD2E1MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(7)]
        public  void ImportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidMMArrayD2E1MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidMMArrayD2E1MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidMMArrayD2E1M),
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
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
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
FROM public.binary_guiduuidmmarrayd2e1m m
LEFT JOIN public.binary_guiduuidmmarrayd2e1mi mi ON mi.id = m.guiduuidmmarrayd2e1mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidMArrayuuidMMArrayD2)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

        [Test, Order(10)]
        public  void ImportModelTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var importCollection = new List<GuiduuidMMArrayD2E1M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidMArrayuuidMMArrayD2)this).ImportModel(connection, importCollection);
                var models = ((IGuidMArrayuuidMMArrayD2)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidmmarrayd2e1mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void ExportModelConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidMMArrayD2E1M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void MMDynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void DynQueryWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void MMDynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMDynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMDynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void DynQueryExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task DynQueryExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void DynQueryExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidMArrayuuidMMArrayD2)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
").ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI), typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            }),
            Gedaq.Npgsql.Attributes.DbTypesOverride(1, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void MMWAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMWAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMWAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MI>();
                var models2 = new List<GuiduuidMMArrayD2E1MI>();
                ((IGuidMArrayuuidMMArrayD2)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2)),
            Gedaq.Npgsql.Attributes.DbTypesOverride(0, new NpgsqlDbType[]
            {
                (NpgsqlTypes.NpgsqlDbType)(9),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621),
                (NpgsqlTypes.NpgsqlDbType)(-2147483621)
            })]
        private void WAExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task WAExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void WAExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidMArrayuuidMMArrayD2)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MI.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidmmarrayd2e1mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA), typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void MMExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task MMExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                await ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void MMExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models1 = new List<GuiduuidMMArrayD2E1MIWA>();
                var models2 = new List<GuiduuidMMArrayD2E1MIWA>();
                ((IGuidMArrayuuidMMArrayD2)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidmmarrayd2e1mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidMMArrayD2E1MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayuuidMMArrayD2))]
        private void ExportModelInnerConfig()
        {
        }

        [Test, Order(13)]
        public async Task ExportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

        [Test, Order(13)]
        public  void ExportModelInnerTest()
        {
            using (var connection = GlobalSetUp.GetConnection)
            {
                connection.Open();
                var expectCount = _testData.Where(wh => wh.ModelInner != null).Count();
                var models = ((IGuidMArrayuuidMMArrayD2)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidMMArrayD2E1MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

