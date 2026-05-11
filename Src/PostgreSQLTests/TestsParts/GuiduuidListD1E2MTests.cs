

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
    internal partial interface IGuidListuuidListD1
    {
    }
    
    internal partial class GuidListuuidListD1 : IGuidListuuidListD1
    {


#region TestData

        private readonly GuiduuidListD1E2M[] _testData = new GuiduuidListD1E2M[]
        {
            new GuiduuidListD1E2M
{
    Id = 9,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a1fdc235-bc04-4d5f-b4c2-fd01eb15e64c"),

Guid.Parse("4e2b0e52-990c-4b20-8729-4c45145f90ad"),

Guid.Parse("b2d0ef48-5cbf-4b37-a363-3a9145d28b9a"),

Guid.Parse("31d5f038-ebc5-41a9-977d-c88cacdaeccb"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 11,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("458de217-682f-4a9d-9b8d-bf79830f9315"),

Guid.Parse("045b5947-cdfb-4c53-a17f-f82956868975"),

Guid.Parse("c9e77d23-d06e-476e-b90d-58e62218af38"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 4,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a4f0228d-69b3-48c4-8629-bada9a72dfe0"),

Guid.Parse("0cbc1d72-ab7b-4abe-b0cf-5e164db1dec5"),

Guid.Parse("cf4026a5-2439-406e-b0d5-65de4f69ee68"),

Guid.Parse("41c72ba8-ea63-4477-a76c-ecc50265bb81"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("99b6ad93-383f-4532-a62c-09e83c042795"),

Guid.Parse("0bc74b45-abe2-429e-9468-978715619faf"),

Guid.Parse("e7b5e35f-dc2c-4e0d-95e2-da59f3c0ef37"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 14,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4115305a-6dba-4982-bc16-43582fa9778b"),

Guid.Parse("707ca13a-01e9-46c9-8c8f-9e5aab757220"),

Guid.Parse("da66113f-7a02-4a39-9491-f58da380f9d3"),

Guid.Parse("5e30d0f6-108b-4176-9374-4aa5c1a039fe"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 20,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("ae41e72c-fd3c-4f3e-a97b-bef43f8ec2fd"),

Guid.Parse("b04fdd9f-4a46-445e-99ff-a4ec2c6646a7"),

Guid.Parse("2423dbee-adda-45e1-8ecb-b55090e19ce1"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 12,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c505cf97-890f-4fb0-968d-b575146bc3ae"),

Guid.Parse("671beb20-f429-41b9-bc8a-e7e39103d8ed"),

Guid.Parse("423249b2-5a9e-4e38-b5b9-4d5edf97d79a"),

Guid.Parse("3d2170ac-58ad-409d-8601-3e1b7bbcc704"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9065a65a-a637-4a74-bb4c-fc01826d4458"),

Guid.Parse("38bcd31d-bf34-4b82-b784-c03d9047979f"),

Guid.Parse("8f7d71ca-de06-48fe-962a-1ba1193519f0"),

Guid.Parse("0b4ea7ef-e18d-4ee2-aab6-1be5ce9c7963"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("1b1f4462-8b97-4e8f-9957-d73fd07e8e09"),

Guid.Parse("9aebf307-3540-412a-bb18-64dcb896a270"),

Guid.Parse("e9784327-e1ac-4029-9bf4-3dc800d88829"),

},
},
            new GuiduuidListD1E2M
{
    Id = 22,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("662c2146-3cd6-4b9a-b206-859b0accfec0"),

Guid.Parse("dcf5f372-36bb-43d6-8a31-7ae86751205b"),

Guid.Parse("13214274-8821-4c28-a53e-46ac1417522d"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("182d63dd-28c5-4760-86f9-c37d36188aca"),

Guid.Parse("8d4a7752-f837-4989-a169-294b895fc84b"),

Guid.Parse("3967c94f-ec77-4ecd-a0ca-9a9764ec3a7b"),

},
},
            new GuiduuidListD1E2M
{
    Id = 25,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("83a8c0f9-b9c6-40ba-9e9f-87594c37f696"),

Guid.Parse("169b47a9-a9e2-4dd7-bd5d-e3f026437d9d"),

Guid.Parse("60375ef1-f4e9-4d07-a550-27cb705387e6"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 21,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("967fef50-6225-4967-a987-d49d3c490603"),

Guid.Parse("c2c364a1-d103-43aa-a8ad-ca8b13d75c52"),

Guid.Parse("635c6c7c-9300-4d40-a7cd-d0321fa32e51"),

Guid.Parse("a31220a7-576c-40c9-98d7-f438f08b85f1"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a46f7912-b538-45e1-929a-93663fb11591"),

Guid.Parse("36911963-9c22-4276-b252-673cbb18fc94"),

Guid.Parse("5a7314ea-8e03-4b00-9d5f-3179b63179be"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b396764f-87c6-45d0-82af-87cc5c9ffed8"),

Guid.Parse("52202458-7ad3-4262-841a-46c2ae0e45cc"),

Guid.Parse("4235ac82-6967-4417-9519-b1aa87dd443a"),

},
},
            new GuiduuidListD1E2M
{
    Id = 42,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2406ab0a-cb8c-4558-83d5-06494c1c352b"),

Guid.Parse("5515cbd2-9bc1-4939-94fb-69758954b3f6"),

Guid.Parse("741e7ea2-e735-4235-a562-0a36b992bfc0"),

Guid.Parse("372a1174-31e7-43e7-81e3-83d88b9c3f3f"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 30,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6ac57d25-657c-476a-9cf4-d7529345667a"),

Guid.Parse("f747e0b1-8912-456b-a889-631fa5e4ba0c"),

Guid.Parse("cf1418bb-2345-4e50-97e2-2cb53414e1ff"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3798e74d-82b9-4c27-8639-b17a1767e629"),

Guid.Parse("893d5afe-1dfd-4423-be45-7695527ab7f5"),

Guid.Parse("1472ef2f-07e7-45d8-83c8-1b08ac2ddc4a"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 51,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("0d6dd453-0e87-40bb-b56e-de481d92a198"),

Guid.Parse("81ae8912-a3f7-4caa-aecb-d4389de940b4"),

Guid.Parse("d2cca657-2c43-4254-a7b8-20239a5872bb"),

Guid.Parse("1f08ac7b-afad-45a5-b09b-aeee151cfa7e"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("198fc448-636b-4ed7-bc30-f98d79db1991"),

Guid.Parse("82a309b1-7164-4170-80b3-f04a6e9fda4f"),

Guid.Parse("ff782004-980f-49a9-9db5-d4811f21ef43"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 31,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("840180bd-46d5-4b9c-8ec9-05792f6a1488"),

Guid.Parse("d1a0d997-75c8-4627-954b-81081ab6683d"),

Guid.Parse("46bb6a19-4762-4290-a4af-250e5ff78b48"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("66c40213-85f3-456a-8c47-b64291e27474"),

Guid.Parse("fe32505f-dde0-4546-bc2f-111cdab46ba3"),

Guid.Parse("a2e7c0de-3709-45fe-81de-312c2aa1f3d7"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 56,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("2e8a1ba6-5247-4a4e-9577-92d78bb99945"),

Guid.Parse("6401ccae-bb96-4521-bd48-559c340ceb17"),

Guid.Parse("fb79dd52-0009-427b-b48b-a9640fe96683"),

Guid.Parse("bfde890e-ee62-4053-ae92-bbc18f5756c1"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 60,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dc3b00fc-2b6e-4062-98ec-9d4cceb263f8"),

Guid.Parse("58246600-fcd7-4be6-aa57-a4f3325fe79d"),

Guid.Parse("384dcffb-f33c-4f23-a398-1bf666d12cc4"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 33,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("4cd69e69-1478-4e63-98e7-a7957dc2ef3c"),

Guid.Parse("724e8f27-1938-4842-871e-a6a653969249"),

Guid.Parse("176afd93-db88-43e5-9618-beba2f89248a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("967c9383-6959-4691-b4c2-af1747edbcb9"),

Guid.Parse("1e0c9660-8787-4ff6-911c-5619f09698cc"),

Guid.Parse("cc825c12-00fb-41f4-b32e-c7c4153fad8a"),

Guid.Parse("31bbae66-6121-4683-ba05-644d955ea314"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("80aab3c9-fd67-4e59-879d-4def397d073c"),

Guid.Parse("9ef1e0c0-f3f0-421a-8143-68621dd8f3bf"),

Guid.Parse("527242aa-bb1d-4d02-a9b4-7e260eb22b6b"),

Guid.Parse("025270e1-3c5f-45e0-9e52-47fa8377ba1e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 69,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("171a057d-c5a0-4b60-b066-9ad190d96ec8"),

Guid.Parse("0a83027c-1bfe-4c3e-96d7-96c31ca7c1a9"),

Guid.Parse("574d8197-f911-4d95-a1ff-dd3136e92986"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e37f5c10-9b5b-482a-a264-61f6d2d2f439"),

Guid.Parse("825d4882-f486-4034-a3ea-54773574389d"),

Guid.Parse("d6f9e648-2946-4a1e-98de-b779346c72fb"),

Guid.Parse("b27780c1-5c3d-4ba9-a23b-f579473a2750"),

},
},
            new GuiduuidListD1E2M
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("6718b952-3d92-470f-b609-17ad4073e843"),

Guid.Parse("cf6e5aeb-83b1-47c9-bde7-61b9671c6552"),

Guid.Parse("79ece2ee-1b3e-4b19-8e5c-0bdf7fb2011c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 39,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("bae106ec-da0f-4436-8f81-052f8829b70e"),

Guid.Parse("4b63151a-d521-4403-ace1-ae57ba50337b"),

Guid.Parse("ed3c6655-599d-496f-b81a-91f39bc0fe2a"),

Guid.Parse("81af5878-91ef-490e-8f71-52bad1d61e1a"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b5434b1c-2ce2-4ed1-b809-960bdbdb3d04"),

Guid.Parse("6f00e460-881e-4398-83cc-4ee1951c8bf9"),

Guid.Parse("e1b1a608-9d18-4bce-a973-f91368e252a8"),

Guid.Parse("948c3157-7d68-41e8-b8ef-c9ed342bbac7"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 76,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("5f0453de-607a-4b36-8d6f-916351f4ac0b"),

Guid.Parse("6396b1bc-5d5d-48a8-9e83-d70899e16fa9"),

Guid.Parse("064a8444-4418-4edb-80fa-ae78ed096884"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 79,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("c55be188-6702-4bdf-b5e4-2bc98cb4e7a5"),

Guid.Parse("2b10c708-0025-4285-bab4-5d729d89f2e3"),

Guid.Parse("93268b83-7ca1-45f0-bd00-fd5a451e9298"),

Guid.Parse("0102cb32-ecfc-4b67-8a87-63febf554b36"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 41,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9954ec59-059f-4028-b7c1-a561a163b73e"),

Guid.Parse("a42e3ae3-ec3c-487b-97b9-1bc9ddde5f25"),

Guid.Parse("b6a78584-62db-4b2f-92ad-a035e14e4377"),

Guid.Parse("b90bc780-27ee-4430-8e6b-df5538527dbd"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("44d6f7c1-7a58-4f4b-b1a0-8d7a9e162402"),

Guid.Parse("9fffa846-574e-4dc2-87e2-dcec8aad5aa2"),

Guid.Parse("54a54889-b50e-4e28-9533-f98c094d82d6"),

},
},
            new GuiduuidListD1E2M
{
    Id = 87,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("8e4fa658-0774-470c-a821-4562e134afee"),

Guid.Parse("8f3aa71b-3d8a-4188-9bc3-71254666375f"),

Guid.Parse("06803ba2-e633-4edf-a87f-e03107ca4155"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("97df4ee7-d1f3-49af-ad16-a25d52398fb1"),

Guid.Parse("327f5ea8-46b7-41e7-9010-2a7614aaee76"),

Guid.Parse("eb20e1d5-fece-4b19-81da-26f9f323b63c"),

},
},
            new GuiduuidListD1E2M
{
    Id = 96,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("642388f1-ffef-4a59-8f8a-9dde43247fd5"),

Guid.Parse("401c04fb-911a-42fc-8d19-3118cd8d492c"),

Guid.Parse("61ea2943-28bf-4209-b02f-95713032608c"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 46,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("657c0031-6c16-40c4-a653-c128bff41bbe"),

Guid.Parse("a1d14740-3bc7-4fea-bd71-aa0f0059e243"),

Guid.Parse("e5382e9c-66bd-42ae-8359-b6370f92e978"),

Guid.Parse("3b2a46dd-91f3-48c1-bd0d-549d7dba0be6"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("927a914c-b4d4-48ce-953f-6a74d5d0930d"),

Guid.Parse("ef7cef0b-d842-43ef-bedb-bfb3f03193a1"),

Guid.Parse("c1aabac9-a0ab-4402-8d10-6e91270f9238"),

Guid.Parse("7abc1deb-c705-4b21-b3ae-790547a1d8ce"),

},
},
            new GuiduuidListD1E2M
{
    Id = 97,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a08f536e-2869-4f31-92f7-38d19c84664d"),

Guid.Parse("1c93efb8-1c84-45ad-8594-06ce939551fa"),

Guid.Parse("aa238d9a-a511-4a76-a1b0-74f8eae4c6be"),

Guid.Parse("a6bd8fca-7a9a-491a-8867-06eae5d76436"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 98,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("1a20635a-0d38-4370-b815-acbe5f9f4046"),

Guid.Parse("26ce800f-4b89-4ef8-b065-796c1391220f"),

Guid.Parse("4f7a4d25-8651-4c87-b23e-8f9f1cfbd85a"),

Guid.Parse("37dd040c-99ff-45a8-8f1e-366bb0cdee45"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 53,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("019fe41a-238c-46a7-9f47-b86d7bd7a07a"),

Guid.Parse("0ff2a103-43fa-48bc-98d8-8a6ef77ae257"),

Guid.Parse("106280db-a015-41b3-b0c8-b55a6999b17e"),

},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 100,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("c47a1423-aa8c-472d-a430-61e58b50c19a"),

Guid.Parse("64b8292b-1c82-4317-93a3-15bf4731fea3"),

Guid.Parse("78c9acf0-19b8-491d-8009-8bbf3414d267"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 102,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("82a6f758-6cc5-4c7f-bff3-3ef2dfc821f4"),

Guid.Parse("19e37f0a-e225-4d56-8a1b-aea8328468ff"),

Guid.Parse("ff081f97-c134-4834-a3ab-2cad4c0e8efb"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 54,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("067bd4f2-6e5d-4e22-ab04-f85e5f9c0892"),

Guid.Parse("4bb94e20-d83c-4607-a690-e06653776490"),

Guid.Parse("83ff6540-8edd-4a18-b761-3a9d17d4d589"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("75b78e90-a566-4ad3-8074-645691c1197f"),

Guid.Parse("c43b5b6f-fee3-4f7c-bbd2-f7d68b188a4b"),

Guid.Parse("75445ecc-83cc-472d-947b-f91c6f724868"),

Guid.Parse("c858ca53-264e-426a-81e6-bdda43ebb77a"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 106,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b26781f1-7a03-46f6-b7fe-d595fb0aa49b"),

Guid.Parse("0790000d-d12e-4f83-861a-43f3db2db3fa"),

Guid.Parse("3dd3db04-2337-413c-a1fc-0bda39a5007b"),

Guid.Parse("889fcddb-7001-4f1d-bc07-60f289e24c67"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("a75a1266-dcc3-40fb-824c-a14d8177db3f"),

Guid.Parse("d1adc17e-ef51-44f0-a38a-98ac10745344"),

Guid.Parse("6d1512ee-b99e-4af3-8495-055ad8283902"),

},
},
            new GuiduuidListD1E2M
{
    Id = 112,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("facb070f-6c73-402d-aed2-4d061e86abf3"),

Guid.Parse("fb03e1e2-bd8c-439a-83d6-3fcf1a4d91cf"),

Guid.Parse("5230b991-2e89-489e-9ec5-300c1845e9fd"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 63,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("be36029f-f00d-486d-b07d-0161793fd75f"),

Guid.Parse("4d3b6ce9-a3f9-49bb-a9ba-680d70b2e603"),

Guid.Parse("a6856a3e-17d3-4265-8b19-797a076d19f9"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4498780c-0a9e-4bcc-bda8-e435ccdc6af4"),

Guid.Parse("65abe628-d23b-46ee-8eef-f13a94888acf"),

Guid.Parse("89ed56d9-7126-40d0-960c-7a3cf883b96c"),

Guid.Parse("76449fb9-df32-4c98-954d-71aac33fb381"),

},
},
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 118,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("938fce76-5355-4f6c-92e4-56b86affe6e2"),

Guid.Parse("a56a4121-5c2d-4dd4-afd2-144f07ff1897"),

Guid.Parse("58938821-f4a0-4d58-93e8-ddea7383643d"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 122,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("4625a164-b63f-4ca5-9abe-26a126008d40"),

Guid.Parse("c906c27c-1e1c-4c6a-a79d-819f6cd32c3a"),

Guid.Parse("2ef25f18-8a72-4617-bbbb-67d24ec46fd1"),

Guid.Parse("75223146-84c3-4ce5-8557-5927f5c20979"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 70,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9fd07fae-f3d8-424b-857e-e97e1f15a41b"),

Guid.Parse("a955cf64-c5a2-4e9e-81cd-1411389e32ae"),

Guid.Parse("4a52bc25-1ab9-4440-a28c-e1d14ece3d81"),

Guid.Parse("002f1c77-05e7-4e1f-8be3-8a70fed03486"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("3ea2d088-192a-4a10-8d5f-9811ed0bc789"),

Guid.Parse("84ae910a-1cd0-487f-bf70-02acccef1ffe"),

Guid.Parse("360b3454-3b32-42c1-a4c5-2886ce8e6ba8"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("61276137-7c00-472f-a278-e8979f430d34"),

Guid.Parse("b27be6a7-90f3-4229-b58b-5de25a5fa4db"),

Guid.Parse("381a9679-f52b-4396-9347-36c9777233c5"),

Guid.Parse("d5b723bd-f626-442a-abc4-57905615526e"),

},
},
            new GuiduuidListD1E2M
{
    Id = 129,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("bd30e6c5-6fbe-4755-bbc5-b2633135d22a"),

Guid.Parse("55948c04-fc3b-4d17-a80d-8c5975fca190"),

Guid.Parse("7630e86d-c05c-471c-9a08-0084fa9e64e6"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d86e9124-303f-4a9e-8bdd-be2d4e9858e9"),

Guid.Parse("a2cd6fd8-3a00-4659-8216-197cf2470609"),

Guid.Parse("03cd33b2-ba8f-4260-ab51-687e1afcb0f2"),

Guid.Parse("8fc4f959-3172-4af6-a2f0-00275bd491d7"),

},
},
            new GuiduuidListD1E2M
{
    Id = 130,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("281e2e74-7661-4f1e-8f21-cad639e8579b"),

Guid.Parse("680a6e5d-c246-415b-937d-5f28b27f227e"),

Guid.Parse("a0cbf624-86dd-4580-8061-c59466bfb27a"),

Guid.Parse("963c22e6-b07c-4b54-be9d-b9eba24f4440"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 74,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("31597070-c07a-425b-9d0c-dfce36fa47d7"),

Guid.Parse("7991054a-b1d9-4e3d-bdd2-b1910e39c4f0"),

Guid.Parse("718628d7-0d6c-4ba1-8f65-6c20a03b927f"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("eabd89ee-eb43-49be-a570-d0742bf25464"),

Guid.Parse("ee509272-91eb-4b39-a43e-313d673bbbcc"),

Guid.Parse("0842c27a-798d-4e5d-b06c-8d45b5ef474f"),

},
},
            new GuiduuidListD1E2M
{
    Id = 137,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("3a9fbb3a-354d-43f0-b959-de65fbb61199"),

Guid.Parse("64c8ffc3-a5c3-4ebb-8e91-c42fe8190c49"),

Guid.Parse("bbf0751c-167b-4fc9-bf8a-0851f8caf274"),

Guid.Parse("95e79175-a697-4e11-9cbd-95f60c6bcf17"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("b46256cb-a717-471a-9384-12caa352c5e4"),

Guid.Parse("6980f575-edbf-45ab-bb9a-090a44484a1a"),

Guid.Parse("8d1fc9d9-a2b3-4511-ba6b-1732d613b8de"),

Guid.Parse("5ab4a3c5-9044-4ef8-84f0-fd8e477ccc30"),

},
},
            new GuiduuidListD1E2M
{
    Id = 140,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("09f48e34-5989-4ef3-a84d-f54be89d05cd"),

Guid.Parse("f185db94-e7d4-4e42-9a84-066a5a3993a2"),

Guid.Parse("7f71412b-d972-45a8-bdc9-c5a757a06a63"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 80,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("a170f4c4-3127-481a-95e3-346920e7e4ea"),

Guid.Parse("0304d181-3589-4f1c-8220-8da4d27dbe85"),

Guid.Parse("4010b777-d741-46a2-abb6-fe8ceb7a6e3e"),

Guid.Parse("d91aaa2e-6466-4548-9aa1-736ea2db56ed"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b7f89b2b-b28c-47fa-9cd7-ee5afbdb576c"),

Guid.Parse("8bf7d7d9-ed7d-419c-b883-a111bde11b08"),

Guid.Parse("f012d7d7-0066-4ca4-b20c-0a90ecee17bc"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("547d4a50-1698-44fa-809c-bb0ba73ee760"),

Guid.Parse("b4b6ef13-d4d3-4601-9a28-bedab3fc256f"),

Guid.Parse("d9520a36-6c0c-4b80-8eba-bbc37917bac9"),

},
},
            new GuiduuidListD1E2M
{
    Id = 143,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("9e1865ba-12d8-4c65-88f8-fe13ee9356e1"),

Guid.Parse("a58d8663-1122-4aac-b238-d30338a28554"),

Guid.Parse("e45bc9bd-ae5b-4be6-bbf6-93ecb391a08b"),

},
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidListD1E2M
{
    Id = 147,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("64e84bf1-bf49-4476-84cf-2283588aaaf2"),

Guid.Parse("5e858de3-7285-4054-9d0f-3689e4d68404"),

Guid.Parse("7cab3363-b16d-40fb-8845-6a5cb1593af9"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 84,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("b3de0a8a-c99f-4d4d-8e7b-770113737988"),

Guid.Parse("d68d3a63-99fd-41e1-a730-8654f39c57ea"),

Guid.Parse("8fe6cbac-8454-4543-8683-82e747ae43d4"),

},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("fc10abfa-79d9-402a-bb28-4a297250b615"),

Guid.Parse("a038c374-7ad0-41a5-889d-7c4ce6a9a37d"),

Guid.Parse("2005f5d3-9515-4c11-a923-4c84a6299bf6"),

Guid.Parse("a2baed5e-87be-47ea-ad68-eb5ef066d8e7"),

},
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("d32339bc-e17e-42cb-9029-53931519b7ca"),

Guid.Parse("209648b7-bc4d-4798-8ac3-0a9d72a17c0c"),

Guid.Parse("b6b9c559-aaa0-4989-92da-48a5be01a731"),

Guid.Parse("f56a1959-41b4-4cfc-bf1d-2ec43c5aa49f"),

},
},
            new GuiduuidListD1E2M
{
    Id = 155,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("20e49823-3185-4607-acab-af999ee3acc7"),

Guid.Parse("3ca6f8eb-c22f-48ed-8edc-e5e43f9af823"),

Guid.Parse("f0da1091-d94d-4e87-a3f2-9339c64d850c"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("9bf0a485-d78f-44a4-a8ec-eb81807905d9"),

Guid.Parse("08daffbe-c349-4597-98cb-d8622cfb1293"),

Guid.Parse("e7288be0-880d-45e3-8de3-c59379bd2bb1"),

Guid.Parse("35ff1e32-a4f8-4487-a80b-f90c5161b4ef"),

},
},
            new GuiduuidListD1E2M
{
    Id = 157,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("e182a63c-110a-4ed4-b606-0d0c7f82eff1"),

Guid.Parse("8477485a-35a5-4b03-b7dc-4b937051bee0"),

Guid.Parse("a78a7b6f-3c26-4ba7-ad80-2818266c458b"),

Guid.Parse("3bdfc355-2277-4ecc-9a63-8cb3a63e2412"),

},
    ModelInner = new GuiduuidListD1E2MI
{
    Id = 89,
    Value = 
new System.Collections.Generic.List<System.Guid>(4)
{
Guid.Parse("323d03a8-5a17-433a-876d-9344a9f9e2d4"),

Guid.Parse("4d424598-1c58-4a17-9ed3-a19e66547608"),

Guid.Parse("af4e9621-1a5f-483f-adc7-c2162c618d8d"),

Guid.Parse("e89bb504-d197-4a24-9c0e-bdaff9bca483"),

},
    NullableValue = null,
},
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("dc18f67b-0594-44df-9895-b3eb39a19e98"),

Guid.Parse("3dc28fe8-d93a-4dd6-af8c-bc413413e9cc"),

Guid.Parse("6412e732-6536-467b-93d0-d818c025ff88"),

},
},
            new GuiduuidListD1E2M
{
    Id = 162,
    Value = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("739eb2a4-64ca-47bc-be75-248f92f53cac"),

Guid.Parse("015b27d6-c507-4a7e-9745-aff3f4a87734"),

Guid.Parse("637498ac-0489-471a-bddf-2988352a91b7"),

},
    ModelInner = null,
    NullableValue = 
new System.Collections.Generic.List<System.Guid>(3)
{
Guid.Parse("134b19e8-076a-454a-ad03-a851812324dc"),

Guid.Parse("0ee973f8-d578-4152-8c08-bc18efa7ef7e"),

Guid.Parse("616282e1-a022-42b4-ae2f-b7470af2cc65"),

},
},
        };

#endregion

#region InsertModelInner

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2mi(
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
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32),
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3,
                methodParametrName: "nullablevalue",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621))]
        public void InsertModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2mi(
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
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
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

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[1].ModelInner.Id, _testData[1].ModelInner.Value, _testData[1].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows =  ((IGuidListuuidListD1)this).InsertModelInner(connection, _testData[3].ModelInner.Id, _testData[3].ModelInner.Value, _testData[3].ModelInner.NullableValue);
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

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[5].ModelInner.Id, _testData[5].ModelInner.Value, _testData[5].ModelInner.NullableValue);
                Assert.That(changedRows, Is.EqualTo(1));

                changedRows = await ((IGuidListuuidListD1)this).InsertModelInnerAsync(connection, _testData[7].ModelInner.Id, _testData[7].ModelInner.Value, _testData[7].ModelInner.NullableValue);
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

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[9].ModelInner.Id, _testData[9].ModelInner.Value, _testData[9].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[9].ModelInner.Id));

                id =  ((IGuidListuuidListD1)this).InsertModelInnerReturning(connection, _testData[11].ModelInner.Id, _testData[11].ModelInner.Value, _testData[11].ModelInner.NullableValue);
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

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[13].ModelInner.Id, _testData[13].ModelInner.Value, _testData[13].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[13].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[15].ModelInner.Id, _testData[15].ModelInner.Value, _testData[15].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[15].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[17].ModelInner.Id, _testData[17].ModelInner.Value, _testData[17].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[17].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[19].ModelInner.Id, _testData[19].ModelInner.Value, _testData[19].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[19].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[21].ModelInner.Id, _testData[21].ModelInner.Value, _testData[21].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[21].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[23].ModelInner.Id, _testData[23].ModelInner.Value, _testData[23].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[23].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[25].ModelInner.Id, _testData[25].ModelInner.Value, _testData[25].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[25].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[27].ModelInner.Id, _testData[27].ModelInner.Value, _testData[27].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[27].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[29].ModelInner.Id, _testData[29].ModelInner.Value, _testData[29].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[29].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[31].ModelInner.Id, _testData[31].ModelInner.Value, _testData[31].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[31].ModelInner.Id));

                id = await ((IGuidListuuidListD1)this).InsertModelInnerReturningAsync(connection, _testData[33].ModelInner.Id, _testData[33].ModelInner.Value, _testData[33].ModelInner.NullableValue);
                Assert.That(id, Is.EqualTo(_testData[33].ModelInner.Id));

            }
        }

#endregion

#region InsertModel

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
            asPartInterface: typeof(IGuidListuuidListD1)), 
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidlistd1e2mi_id", 
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
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[0].Id, _testData[0].Value, _testData[0].NullableValue, _testData[0].ModelInner == null ? null : _testData[0].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows =  ((IGuidListuuidListD1)this).InsertModel(connection, _testData[1].Id, _testData[1].Value, _testData[1].NullableValue, _testData[1].ModelInner == null ? null : _testData[1].ModelInner.Id);
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
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[2].Id, _testData[2].Value, _testData[2].NullableValue, _testData[2].ModelInner == null ? null : _testData[2].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
                changedRows = await ((IGuidListuuidListD1)this).InsertModelAsync(connection, _testData[3].Id, _testData[3].Value, _testData[3].NullableValue, _testData[3].ModelInner == null ? null : _testData[3].ModelInner.Id);
                Assert.That(changedRows, Is.EqualTo(1));
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelDynParReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.DynamicParametr()]
        public void InsertModelDynParReturningConfig()
        {
        }

[Gedaq.Npgsql.Attributes.Query(
            query: @"
INSERT INTO public.guiduuidlistd1e2m(
	id,
    value,
    nullablevalue,
    guiduuidlistd1e2mi_id
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
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    id
;
",
            methodName:"InsertModelReturning",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read | QueryType.Scalar,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                position: 1,
                methodParametrName: "id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>),
                position: 2,
                methodParametrName: "value",
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Collections.Generic.List<System.Guid>), 
                position: 3, 
                methodParametrName: "nullablevalue", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(-2147483621)),
            Gedaq.Npgsql.Attributes.Parametr(
                parametrType: typeof(System.Int32?), 
                position: 4, 
                methodParametrName: "guiduuidlistd1e2mi_id", 
                dbType: (NpgsqlTypes.NpgsqlDbType)(9))]
        public void InsertModelReturningConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningRead()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidListD1E2M> models = null;

                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[4].Id, _testData[4].Value, _testData[4].NullableValue, _testData[4].ModelInner == null ? null : _testData[4].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[4], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[5].Id, _testData[5].Value, _testData[5].NullableValue, _testData[5].ModelInner == null ? null : _testData[5].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[5], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[6].Id, _testData[6].Value, _testData[6].NullableValue, _testData[6].ModelInner == null ? null : _testData[6].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[6], true);
                models =  ((IGuidListuuidListD1)this).InsertModelReturning(connection, _testData[7].Id, _testData[7].Value, _testData[7].NullableValue, _testData[7].ModelInner == null ? null : _testData[7].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[7], true);
            }
        }

        [Test, Order(1)]
        public async Task InsertModelTestReturningReadAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                List<GuiduuidListD1E2M> models = null;

                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[8].Id, _testData[8].Value, _testData[8].NullableValue, _testData[8].ModelInner == null ? null : _testData[8].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[8], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[9].Id, _testData[9].Value, _testData[9].NullableValue, _testData[9].ModelInner == null ? null : _testData[9].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[9], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[10].Id, _testData[10].Value, _testData[10].NullableValue, _testData[10].ModelInner == null ? null : _testData[10].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[10], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[11], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[12].Id, _testData[12].Value, _testData[12].NullableValue, _testData[12].ModelInner == null ? null : _testData[12].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[12], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[13].Id, _testData[13].Value, _testData[13].NullableValue, _testData[13].ModelInner == null ? null : _testData[13].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[13], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[14].Id, _testData[14].Value, _testData[14].NullableValue, _testData[14].ModelInner == null ? null : _testData[14].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[14], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[15].Id, _testData[15].Value, _testData[15].NullableValue, _testData[15].ModelInner == null ? null : _testData[15].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[15], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[16].Id, _testData[16].Value, _testData[16].NullableValue, _testData[16].ModelInner == null ? null : _testData[16].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[16], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[17].Id, _testData[17].Value, _testData[17].NullableValue, _testData[17].ModelInner == null ? null : _testData[17].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[17], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[18].Id, _testData[18].Value, _testData[18].NullableValue, _testData[18].ModelInner == null ? null : _testData[18].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[18], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[19].Id, _testData[19].Value, _testData[19].NullableValue, _testData[19].ModelInner == null ? null : _testData[19].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[19], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[20].Id, _testData[20].Value, _testData[20].NullableValue, _testData[20].ModelInner == null ? null : _testData[20].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[20], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[21].Id, _testData[21].Value, _testData[21].NullableValue, _testData[21].ModelInner == null ? null : _testData[21].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[21], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[22].Id, _testData[22].Value, _testData[22].NullableValue, _testData[22].ModelInner == null ? null : _testData[22].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[22], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[23].Id, _testData[23].Value, _testData[23].NullableValue, _testData[23].ModelInner == null ? null : _testData[23].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[23], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[24].Id, _testData[24].Value, _testData[24].NullableValue, _testData[24].ModelInner == null ? null : _testData[24].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[24], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[25].Id, _testData[25].Value, _testData[25].NullableValue, _testData[25].ModelInner == null ? null : _testData[25].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[25], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[26].Id, _testData[26].Value, _testData[26].NullableValue, _testData[26].ModelInner == null ? null : _testData[26].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[26], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[27].Id, _testData[27].Value, _testData[27].NullableValue, _testData[27].ModelInner == null ? null : _testData[27].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[27], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[28].Id, _testData[28].Value, _testData[28].NullableValue, _testData[28].ModelInner == null ? null : _testData[28].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[28], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[29].Id, _testData[29].Value, _testData[29].NullableValue, _testData[29].ModelInner == null ? null : _testData[29].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[29], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[30].Id, _testData[30].Value, _testData[30].NullableValue, _testData[30].ModelInner == null ? null : _testData[30].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[30], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[31].Id, _testData[31].Value, _testData[31].NullableValue, _testData[31].ModelInner == null ? null : _testData[31].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[31], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[32].Id, _testData[32].Value, _testData[32].NullableValue, _testData[32].ModelInner == null ? null : _testData[32].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[32], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[33].Id, _testData[33].Value, _testData[33].NullableValue, _testData[33].ModelInner == null ? null : _testData[33].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[33], true);
                models = await ((IGuidListuuidListD1)this).InsertModelReturningAsync(connection, _testData[34].Id, _testData[34].Value, _testData[34].NullableValue, _testData[34].ModelInner == null ? null : _testData[34].ModelInner.Id);
                Assert.That(models, Has.Count.EqualTo(1));
                GuiduuidListD1E2M.AssertModel(models[0],_testData[34], true);
            }
        }

#endregion

#region Select Models

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var parametr1 = new NpgsqlParameter<int>();
                parametr1.TypedValue = 0;
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                var models = ((IGuidListuuidListD1)this).SelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"MMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).MMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).MMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.Query(
            query: null,
            methodName:"DynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE 
    m.id > $1
ORDER BY
    m.id ASC
"
,
            methodName:"SelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).SelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = ((IGuidListuuidListD1)this).SelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionMMDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTMMDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParAsync(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 56;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(10));
                Assert.That(firstItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(24));
                Assert.That(secondItems2, Has.Count.EqualTo(24));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 137;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 22;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(6));
                Assert.That(firstItems2, Has.Count.EqualTo(6));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynPar(connection,  query, [parametr1], (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
                parametr1.Value = 60;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 122;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(23));
                Assert.That(firstItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(9));
                Assert.That(secondItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 53;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 143;
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(25));
                Assert.That(firstItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[21],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[22],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[23],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[24],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(4));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModelDynPar",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionDynQuerySelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTDynQuerySelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParAsync(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[29],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[30],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[34], false);
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
                parametr2.Value = 97;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatchAsync(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(24));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                Assert.That(secondItems2, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 0;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynPar(connection,  query, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 118;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 118;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[34], false);
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
                parametr1.Value = 97;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 60;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                var query1 = @"
SELECT
    m.id,
    m.value,
    m.nullablevalue
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelDynParBatch(connection, [parametr1], query1, [parametr2], query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(23));
                Assert.That(secondItems2, Has.Count.EqualTo(23));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModelDynPar",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
Gedaq.DbConnection.Attributes.DynamicParametr()]
        private void DbConnectionSelectModelDynParConfig()
        {
        }

[Gedaq.DbConnection.Attributes.QueryBatch(
            batchName: "DbConnectionSTSelectModelDynParBatch",
            queryType: QueryType.Read, 
            methodType: MethodType.Sync | MethodType.Async,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelDynParAsync(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 14;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 112;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(32));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[3], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[4], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[5], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[29],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[30],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[31],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModelDynPar(connection, [parametr1]);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                parametr1.Value = 122;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 147;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(9));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }
                    
                    Assert.Fail("Unexpected batch count");
                }
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionMMDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M), typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: ["item1", "item2"],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                await((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelAsync(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 70, query1, 20, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                Assert.That(firstItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(31));
                Assert.That(secondItems2, Has.Count.EqualTo(31));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[26],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[27],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[28],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[29],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[30],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[30],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 122, query1, 140, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(9));
                Assert.That(firstItems2, Has.Count.EqualTo(9));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(5));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models1 = new List<FlatGuiduuidListD1E2M>();
                var models2 = new List<FlatGuiduuidListD1E2M>();
                ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModel(connection,  query, 0, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(35));
                Assert.That(models2, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models1[i],_testData[i], false);
                    FlatGuiduuidListD1E2M.AssertModel(models2[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 98, query1, 33, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(28));
                Assert.That(secondItems2, Has.Count.EqualTo(28));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[21],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[22],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[23],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[24],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[25],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[26],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[27],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var firstItems2 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionMMDynQuerySelectModelBatch(connection, 98, query1, 9, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(15));
                Assert.That(firstItems2, Has.Count.EqualTo(15));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[0],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[1],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[2],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[3],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[4],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[5],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[6],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[7],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[8],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[9],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[10],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[11],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[12],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[13],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems2[14],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(34));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[1], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[2], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[21],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[22],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[23],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[24],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[25],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[26],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[27],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[28],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[29],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[30],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[31],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[32],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[33],_testData[34], false);
            }
        }

[Gedaq.DbConnection.Attributes.Query(
            query: null,
            methodName:"DbConnectionDynQuerySelectModel",
            queryMapTypes: [typeof(FlatGuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = await((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelAsync(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 20, query1, 100, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[30],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(14));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                await ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 14, query1, 102, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(32));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[28],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[29],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[30],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[31],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(13));
                Assert.That(secondItems2, Has.Count.EqualTo(13));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var models = ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModel(connection,  query, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    FlatGuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTDynQuerySelectModelBatch(connection, 129, query1, 79, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(8));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        FlatGuiduuidListD1E2M.AssertModel(models[0],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[1],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[2],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[3],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[4],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[5],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[6],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[7],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[8],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[9],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[10],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[11],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[12],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[13],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[14],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[15],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[16],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[17],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(models[18],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
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
FROM public.guiduuidlistd1e2m m
WHERE
    m.id > @id
ORDER BY
    m.id ASC
";
                var firstItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems1 = new List<FlatGuiduuidListD1E2M>();
                var secondItems2 = new List<FlatGuiduuidListD1E2M>();
                 ((IGuidListuuidListD1)this).DbConnectionDynQuerySelectModelBatch(connection, 11, query1, 70, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(33));
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[0],_testData[2], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[1],_testData[3], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[2],_testData[4], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[3],_testData[5], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[4],_testData[6], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[5],_testData[7], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[6],_testData[8], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[7],_testData[9], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[8],_testData[10], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[9],_testData[11], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[10],_testData[12], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[11],_testData[13], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[12],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[13],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[14],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[15],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[16],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[17],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[18],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[19],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[20],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[21],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[22],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[23],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[24],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[25],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[26],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[27],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[28],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[29],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[30],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[31],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(firstItems1[32],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidListD1E2M.AssertModel(secondItems2[20],_testData[34], false);
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
FROM public.guiduuidlistd1e2m m
LEFT JOIN public.guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
WHERE
    m.id > @id
ORDER BY
    m.id ASC
"
,
            methodName:"DbConnectionSelectModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            overrideAliasPrefixs: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await((IGuidListuuidListD1)this).DbConnectionSelectModelAsync(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in await ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatchAsync(connection, 98, 25))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(15));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(29));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[6], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[7], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[8], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[9], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[10], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[11], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[12], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[13], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[14], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[15], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[16], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[17], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[18], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[16],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[17],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[18],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[19],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[20],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[21],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[22],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[23],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[24],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[25],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[26],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[27],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[28],_testData[34], false);
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
                var models = ((IGuidListuuidListD1)this).DbConnectionSelectModel(connection, 0);
                Assert.That(models, Has.Count.EqualTo(35));
                for (int i = 0; i < 35; i++)
                {
                    GuiduuidListD1E2M.AssertModel(models[i],_testData[i], false);
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
                foreach(var batchResult in  ((IGuidListuuidListD1)this).DbConnectionSTSelectModelBatch(connection, 97, 112))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[19], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[20], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[21], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[22], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[23], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[11],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[12],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[13],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[14],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(11));

                        GuiduuidListD1E2M.AssertModel(models[0],_testData[24], false);
                        GuiduuidListD1E2M.AssertModel(models[1],_testData[25], false);
                        GuiduuidListD1E2M.AssertModel(models[2],_testData[26], false);
                        GuiduuidListD1E2M.AssertModel(models[3],_testData[27], false);
                        GuiduuidListD1E2M.AssertModel(models[4],_testData[28], false);
                        GuiduuidListD1E2M.AssertModel(models[5],_testData[29], false);
                        GuiduuidListD1E2M.AssertModel(models[6],_testData[30], false);
                        GuiduuidListD1E2M.AssertModel(models[7],_testData[31], false);
                        GuiduuidListD1E2M.AssertModel(models[8],_testData[32], false);
                        GuiduuidListD1E2M.AssertModel(models[9],_testData[33], false);
                        GuiduuidListD1E2M.AssertModel(models[10],_testData[34], false);
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
                await using var cmd = await ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommandAsync(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 112);
                var models = await ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(11));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[24], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[25], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[9],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[10],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidListuuidListD1)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidListuuidListD1)this).SetDbConnectionSelectModelParametrs(cmd, 122);
                var models =  ((IGuidListuuidListD1)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(9));

                GuiduuidListD1E2M.AssertModel(models[0],_testData[26], false);
                GuiduuidListD1E2M.AssertModel(models[1],_testData[27], false);
                GuiduuidListD1E2M.AssertModel(models[2],_testData[28], false);
                GuiduuidListD1E2M.AssertModel(models[3],_testData[29], false);
                GuiduuidListD1E2M.AssertModel(models[4],_testData[30], false);
                GuiduuidListD1E2M.AssertModel(models[5],_testData[31], false);
                GuiduuidListD1E2M.AssertModel(models[6],_testData[32], false);
                GuiduuidListD1E2M.AssertModel(models[7],_testData[33], false);
                GuiduuidListD1E2M.AssertModel(models[8],_testData[34], false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQueryWASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryWAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryWAImportModelInnerConfig()
        {
        }

        [Test, Order(0)]
        public async Task DynQueryWAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 0; i < 4; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryWAImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(2));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 4; i < 8; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryWAImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQueryWASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(4));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"DynQuerySelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQuerySelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: null,
            methodName:"DynQueryImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void DynQueryImportModelInnerConfig()
        {
        }

        [Test, Order(2)]
        public async Task DynQueryImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 8; i < 12; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).DynQueryImportModelInnerAsync(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = await ((IGuidListuuidListD1)this).DynQuerySelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(6));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 12; i < 16; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).DynQueryImportModelInner(connection, importCollection, @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
");
                var models = ((IGuidListuuidListD1)this).DynQuerySelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(8));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"WASelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WASelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
nullablevalue,
value
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"WAImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MI),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void WAImportModelInnerConfig()
        {
        }

        [Test, Order(4)]
        public async Task WAImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 16; i < 20; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).WAImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).WASelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MI>(2);
                for (int i = 20; i < 24; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).WAImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).WASelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(12));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(actual, expect, false);
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
FROM public.binary_guiduuidlistd1e2mi mi
ORDER BY
    mi.id ASC
"
,
            methodName:"SelectImportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelInnerConfig()
        {
        }

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
id,
value,
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModelInner",
            queryMapType: typeof(GuiduuidListD1E2MIWA),
            dbTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void ImportModelInnerConfig()
        {
        }

        [Test, Order(6)]
        public async Task ImportModelInnerAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 24; i < 28; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                await ((IGuidListuuidListD1)this).ImportModelInnerAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelInnerAsync(connection);
                Assert.That(models, Has.Count.EqualTo(14));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2MIWA>(2);
                for (int i = 28; i < 35; i++)
                {
                    var importModel = _testData[i].ModelInner;
                    if (importModel == null)
                    {
                        continue;
                    }

                    importCollection.Add(
new GuiduuidListD1E2MIWA
{
    Id = importModel.Id,
    Value = importModel.Value,
    NullableValue = importModel.NullableValue,
});
                }

                ((IGuidListuuidListD1)this).ImportModelInner(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModelInner(connection);
                Assert.That(models, Has.Count.EqualTo(17));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == actual.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryImportModel

[Gedaq.Npgsql.Attributes.BinaryImport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
id,
value,
~StartInner::ModelInner:Id~
    ~Reinterpret::id~
guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
nullablevalue
) 
FROM STDIN (FORMAT BINARY)
",
            methodName:"ImportModel",
            queryMapType: typeof(GuiduuidListD1E2M),
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
            asPartInterface: typeof(IGuidListuuidListD1))]
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
FROM public.binary_guiduuidlistd1e2m m
LEFT JOIN public.binary_guiduuidlistd1e2mi mi ON mi.id = m.guiduuidlistd1e2mi_id
ORDER BY
    m.id ASC
"
,
            methodName:"SelectImportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
        private void SelectImportModelConfig()
        {
        }

        [Test, Order(9)]
        public async Task ImportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 0; i < 10; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                await ((IGuidListuuidListD1)this).ImportModelAsync(connection, importCollection);
                var models = await ((IGuidListuuidListD1)this).SelectImportModelAsync(connection);
                Assert.That(models, Has.Count.EqualTo(10));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
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
                var importCollection = new List<GuiduuidListD1E2M>();
                for (int i = 10; i < 35; i++)
                {
                    var importModel = _testData[i];
                    importCollection.Add(importModel);
                }

                ((IGuidListuuidListD1)this).ImportModel(connection, importCollection);
                var models = ((IGuidListuuidListD1)this).SelectImportModel(connection);
                Assert.That(models, Has.Count.EqualTo(35));
                var set = new HashSet<long>();
                for (var i = 0; i < models.Count(); i++)
                {
                    var actual = models[i];
                    var expect = _testData.First(wh => wh.Id == actual.Id);
                    GuiduuidListD1E2M.AssertModel(actual, expect, false);
                    Assert.That(set.Add(actual.Id), Is.True);
                }
            }
        }

#endregion

#region BinaryExportModel

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2m
(
    id,
    nullablevalue,
~StartInner::ModelInner:Id~
    ~Reinterpret::Id~
    guiduuidlistd1e2mi_id,
~EndInner::ModelInner~
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModel",
            queryMapTypes: [typeof(GuiduuidListD1E2M)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models =  ((IGuidListuuidListD1)this).ExportModel(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

        [Test, Order(13)]
        public async Task ExportModelAsyncTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                var models = await ((IGuidListuuidListD1)this).ExportModelAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(_testData.Count()));
                for(int modelIndex = 0; modelIndex < _testData.Count(); modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.Id == model.Id);
                    GuiduuidListD1E2M.AssertModel(model, expectedModel, true);
                }
            }
        }

#endregion

#region BinaryExportModelInner

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryWAExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).DynQueryWAExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryWAExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"MMDynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMDynQueryExportModelInnerAsync(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMDynQueryExportModelInner(connection, @"
COPY
(
    SELECT
        id,
        value,
        nullablevalue,
        
        id,
        value,
        nullablevalue
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
", (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: null,
            methodName:"DynQueryExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).DynQueryExportModelInnerAsync(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).DynQueryExportModelInner(connection, @"
COPY public.binary_guiduuidlistd1e2mi
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
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMWAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI), typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                await ((IGuidListuuidListD1)this).MMWAExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MI>();
                var models2 = new List<GuiduuidListD1E2MI>();
                ((IGuidListuuidListD1)this).MMWAExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    nullablevalue,
    value
) TO STDOUT (FORMAT BINARY)
",
            methodName:"WAExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MI)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1)),
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
                var models = await ((IGuidListuuidListD1)this).WAExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).WAExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MI.AssertModel(model, expectedModel, false);
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
    FROM public.binary_guiduuidlistd1e2mi
) TO STDOUT (FORMAT BINARY)
",
            methodName:"MMExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA), typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                await ((IGuidListuuidListD1)this).MMExportModelInnerAsync(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
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
                var models1 = new List<GuiduuidListD1E2MIWA>();
                var models2 = new List<GuiduuidListD1E2MIWA>();
                ((IGuidListuuidListD1)this).MMExportModelInner(connection, (item1, item2) => { models1.Add(item1); models2.Add(item2); });
                Assert.That(models1, Has.Count.EqualTo(expectCount));
                Assert.That(models2, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model1 = models1[modelIndex];
                    var model2 = models2[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model1.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model1, expectedModel, false);

                    expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model2.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model2, expectedModel, false);
                }
            }
        }

[Gedaq.Npgsql.Attributes.BinaryExport(
            query: @"
COPY public.binary_guiduuidlistd1e2mi
(
    id,
    value,
    nullablevalue
) TO STDOUT (FORMAT BINARY)
",
            methodName:"ExportModelInner",
            queryMapTypes: [typeof(GuiduuidListD1E2MIWA)],
            methodType: MethodType.Async | MethodType.Sync,
            sourceType: SourceType.Connection,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidListuuidListD1))]
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
                var models = await ((IGuidListuuidListD1)this).ExportModelInnerAsync(connection).ToListAsync();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
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
                var models = ((IGuidListuuidListD1)this).ExportModelInner(connection).ToList();
                Assert.That(models, Has.Count.EqualTo(expectCount));
                for(int modelIndex = 0; modelIndex < expectCount; modelIndex++)
                {
                    var model = models[modelIndex];
                    var expectedModel = _testData.First(wh => wh.ModelInner != null && wh.ModelInner.Id == model.Id).ModelInner;
                    GuiduuidListD1E2MIWA.AssertModel(model, expectedModel, false);
                }
            }
        }

#endregion

    }
}

