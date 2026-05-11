

using ClickHouse.Driver.ADO;
using System;
using Gedaq.Common.Enums;


using System.Linq;
using NUnit.Framework;
using System.Data.Common;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Tests
{
    internal partial interface IGuidMArrayMArrayD2
    {
    }
    
    internal partial class GuidMArrayMArrayD2 : IGuidMArrayMArrayD2
    {


#region TestData

        private readonly GuidMArrayD2E1M[] _testData = new GuidMArrayD2E1M[]
        {
            new GuidMArrayD2E1M
{
    Id = 4,
    Value = 
new System.Guid[,] { { Guid.Parse("579a7dd0-4158-485e-8658-7c9f3e5108bd"), Guid.Parse("c7fb51ed-c4c2-4b67-96bd-2d9ea87835a7"), }, { Guid.Parse("9c4c1bd2-e170-4bdb-9dbf-0256a05c5d52"), Guid.Parse("87222033-928e-4e7d-b409-9d27533f7e00"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 7,
    Value = 
new System.Guid[,] { { Guid.Parse("6f4dfd52-d14c-4af2-aa13-be5d62d03cf8"), Guid.Parse("7efcb2a9-5ebb-48c6-967c-7c68b59584ec"), }, { Guid.Parse("60deb7de-dd93-4b18-934c-c252fb76badc"), Guid.Parse("79af8f80-d4e2-4141-84c9-c7aa7d3bcc4f"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("bc53dfe9-086c-4ded-9775-008822613eea"), Guid.Parse("325ba5e1-e6b4-403d-a3d5-931b66aa5cfe"), }, { Guid.Parse("12c0c8aa-7138-4b84-8724-f7048599348b"), Guid.Parse("a0f8ef4d-c7fb-47b3-9f62-833526f0d937"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Guid[,] { { Guid.Parse("4ab3c006-e46d-4385-9a32-d3398d5484b3"), Guid.Parse("23e32213-fc79-466e-85eb-0b6ab708f1d6"), }, { Guid.Parse("2efb1e7b-9bc8-477c-b204-21b4c7809af0"), Guid.Parse("3c191622-cedd-44eb-8e1f-f55792e7aa04"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 13,
    Value = 
new System.Guid[,] { { Guid.Parse("4dfad362-338a-4bd1-a85d-a6ae156a9b1e"), Guid.Parse("ab399442-3ce4-4b0e-97d6-cd7ee766cf5c"), }, { Guid.Parse("0159a0ec-1a33-4e4a-b56b-b38574bb56ba"), Guid.Parse("f6e0ec95-054f-42f9-89bd-7faeb4345106"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("17019511-e69e-4e2d-bd11-c9f33b6055a7"), Guid.Parse("7c2b9fd2-1517-4b86-ad1e-9b9279845fc3"), }, { Guid.Parse("7a827e07-8f49-462b-a3b0-52fa55b3c7ff"), Guid.Parse("bdcf762b-8e87-43a6-9a31-cb341a959740"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 19,
    Value = 
new System.Guid[,] { { Guid.Parse("e9ff287e-1310-4f43-96f9-fb0e5a57262e"), Guid.Parse("0ee21aa1-d1e6-4ca9-aa2a-442b8dfa99b2"), }, { Guid.Parse("71f16853-d771-4e56-a91e-7673fb3362f9"), Guid.Parse("facd39ab-eada-45a7-90b2-9e6006713b9e"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("693771b2-982b-40b1-b8e3-95ad791d5a30"), Guid.Parse("d8f30536-1936-4fe4-9765-3af5868ccdd1"), }, { Guid.Parse("c17e41e6-39d3-46ea-ade0-7c810b8a4b0b"), Guid.Parse("265a035f-263b-41be-a9d7-32d2762fcfe7"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5cedf40e-02ed-4d24-a0bc-581b6e4aadbd"), Guid.Parse("98bcbfd7-913f-4104-bf89-891f9fd16d54"), }, { Guid.Parse("810cb207-7d18-4752-b47f-6a75e5624ccf"), Guid.Parse("a7a21e12-e75c-4307-9cdc-8a2af090ec96"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 28,
    Value = 
new System.Guid[,] { { Guid.Parse("dbdec5ec-2e8e-4821-9efa-5b4b319b92b4"), Guid.Parse("680b1639-768f-46b8-9644-fcd30004bcc0"), }, { Guid.Parse("00362083-6b47-46e2-8054-86c75c45fc87"), Guid.Parse("79324260-50db-4231-a83a-ad007a67a5f1"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("05a4034f-17b5-4287-ae3e-ba2e243e67d2"), Guid.Parse("3983e47d-8c40-407e-98de-51892b91fa03"), }, { Guid.Parse("88c3003a-d38f-4b68-87bb-4df1c25c6ee5"), Guid.Parse("94e52533-51d4-4bb5-869f-6705c6e7e754"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("9db9f578-5f18-4d73-a31d-a8b025b2d0e3"), Guid.Parse("00fa4be9-980e-4bf5-a615-cca4dd70776f"), }, { Guid.Parse("ec3b900e-508d-4d57-8dbe-8b4fc7adedb7"), Guid.Parse("c7d39c26-788d-469a-a2b0-cfa28048130b"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 37,
    Value = 
new System.Guid[,] { { Guid.Parse("d0c9727f-9d79-4b67-b9a7-4f1ff13417dd"), Guid.Parse("1c1d2dc2-6b21-4afa-8d67-04fb0ef416ba"), }, { Guid.Parse("e18bc2b1-2a91-4832-87da-916f77b27511"), Guid.Parse("b720fa2d-2886-497b-841d-3da34a6a4032"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("f24e49da-d33d-47e8-979e-8690018cc4af"), Guid.Parse("d901b07a-df0a-428e-8940-f22f11d296be"), }, { Guid.Parse("e86910b5-d499-42e1-96a0-a458fda5b31e"), Guid.Parse("6fa0af9b-a4ba-423a-83a5-0213c9abbac7"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("41c14a5d-26b8-4f4a-9f3f-3ecb63ebc393"), Guid.Parse("7c7d2ef8-d2a1-4145-a321-90fb6143a55c"), }, { Guid.Parse("8e3438af-1cd3-4a9a-b97e-3b5df9d84b9b"), Guid.Parse("29326161-1aed-45aa-88a0-0c8b95f3acb7"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("a9a6d3ce-6410-4229-9a07-63282df5f4df"), Guid.Parse("bf7f8624-3be5-4bc0-8752-41c964d02df5"), }, { Guid.Parse("78b69a6d-f7d8-4c00-87bc-2a1cf76e5eaa"), Guid.Parse("3cc95759-090f-47eb-9c9c-9cb35bc018f8"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Guid[,] { { Guid.Parse("5cec1bfc-36ec-45a1-a6f7-5b88dfde1591"), Guid.Parse("df2abb84-924f-49a5-8f20-4e0cf50ef71a"), }, { Guid.Parse("6a9150f2-b9ee-491c-aefc-68800530c830"), Guid.Parse("61e45a36-10fc-45a8-9d18-f972d43fd4a8"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ab2eb4d8-5f05-4b8e-b404-c7233d9dda72"), Guid.Parse("6e4a3b8b-23b2-41ae-af27-372745e7dbbf"), }, { Guid.Parse("b5cc0bfb-a9f7-420a-94a5-b8c33002dbbd"), Guid.Parse("969ac129-c8e5-4d47-a5f9-a4ad9d0d04b5"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("64c22f6e-f8f7-4f59-b570-0d769e726d12"), Guid.Parse("748b3c2b-34e0-47b5-8b69-0a8cda551760"), }, { Guid.Parse("d003b5ff-9882-47e0-95a2-cc8770d73de1"), Guid.Parse("83cdcf03-ae50-4220-8771-4316f707b8a1"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("0b138a88-f8b0-4df9-97a5-503459ab1db8"), Guid.Parse("b2283012-7a85-4e38-b659-c3101530a4b6"), }, { Guid.Parse("25698b99-39c2-487c-bc89-4443b0c1f868"), Guid.Parse("981017a6-5466-4cbb-a1b2-237b48428662"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1dcaf088-6ba8-4d2e-bc7b-5d0001c70285"), Guid.Parse("9d75137a-d37b-4d96-bdd6-e05705c71f1a"), }, { Guid.Parse("8fd52c28-e473-4e36-aa39-1bd668a2edfc"), Guid.Parse("db0a11a7-1e49-4301-97ee-f6c55ec65e42"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f49d4268-2811-423b-86b7-d6b863931cab"), Guid.Parse("42b5350f-f6f2-4fe2-bf13-5553b3218a5e"), }, { Guid.Parse("28d1a4db-cf4a-4dbf-8012-f93515e3422b"), Guid.Parse("1f64c061-6685-41e2-9d4f-7d62f7950c29"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 63,
    Value = 
new System.Guid[,] { { Guid.Parse("c8ba88b5-18f6-4d56-a776-03030a4f240b"), Guid.Parse("e8f2bd37-adcd-4fe5-bab5-972ed72b43da"), }, { Guid.Parse("ecdb1d54-0c37-4041-b588-8eeb076a045f"), Guid.Parse("f42a3b07-a15f-4f00-9c9d-aba1f7c146d8"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 43,
    Value = 
new System.Guid[,] { { Guid.Parse("befb7e0e-a888-42cb-b99b-9755633b9456"), Guid.Parse("efe5b534-00e2-4b1c-8dbb-7caf93bb062d"), }, { Guid.Parse("c0555e35-8598-47ba-9081-2c42af408ef5"), Guid.Parse("34ddb2f9-4c0c-4bee-9f64-9b5d38bb22eb"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("64d3e4c1-dfa0-413e-8848-80a4a210471c"), Guid.Parse("0ae174d3-a4a5-4dec-86d9-6c42f058bf32"), }, { Guid.Parse("cfc40dbc-18b9-4be6-866b-b19ac3350b40"), Guid.Parse("619d1b02-37dd-414f-aa6c-8055b7d9d03e"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("1cc40ccb-f93b-4e8b-b090-2bdeb89ce941"), Guid.Parse("f9516ec9-98a9-4bb4-8a94-70dbacd29bf2"), }, { Guid.Parse("5939755c-c4ae-4271-942d-232c9f38db4c"), Guid.Parse("883ddd9a-3868-4835-8033-b2251a220464"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 71,
    Value = 
new System.Guid[,] { { Guid.Parse("f1039604-0598-4965-baa7-d0d576f5e915"), Guid.Parse("cc3ce1a8-63fe-4ed0-b2b7-265d38dc001a"), }, { Guid.Parse("0820610b-3388-49ac-8216-16d5d811d64d"), Guid.Parse("090c10bc-7c5b-4c32-b626-9d71699d5bd4"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 49,
    Value = 
new System.Guid[,] { { Guid.Parse("5910ec0e-e146-4793-a537-02884a3fecfc"), Guid.Parse("938218b9-58a3-4e27-afab-5614fa3500e6"), }, { Guid.Parse("1d5a1f0c-8921-4713-9287-2c6c717fcd54"), Guid.Parse("14f69c70-45ae-45ed-acb3-8d1f417cf90a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("840abbc3-dee5-44dd-ba1e-c212c9cda31a"), Guid.Parse("dad88442-9630-49cc-a914-f1bfb14c4b6e"), }, { Guid.Parse("9f16ffc6-9991-4ff5-8d4a-459de42ca48c"), Guid.Parse("d748545a-9ba9-41a4-a811-495e83c109c5"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 80,
    Value = 
new System.Guid[,] { { Guid.Parse("58b8368b-3999-4074-a5c6-42663e249b85"), Guid.Parse("1600b7bb-bec1-4a2e-9154-485b54c7753d"), }, { Guid.Parse("a33402e9-508c-4c17-9994-62c14d58fc0c"), Guid.Parse("32d34d2a-d6d6-4fb6-a01c-629be138f53d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 57,
    Value = 
new System.Guid[,] { { Guid.Parse("b0c40a48-f1ea-422f-a694-4d3741e0eadf"), Guid.Parse("8b5a8a74-4851-4633-b074-acc6086b80ec"), }, { Guid.Parse("7fceb424-4b38-4a8d-929a-9c6f40720105"), Guid.Parse("e0efee77-1545-4e64-8179-48b9e997b12e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("ee664bba-c7c2-4e03-a07c-c332670a3fef"), Guid.Parse("8fa12774-4c9d-49e3-ab58-f6aea35ccb05"), }, { Guid.Parse("d965df7e-1ff3-4c9a-8599-41376e800358"), Guid.Parse("7f139bb5-8d56-4eef-9c75-0dc311315ec2"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d134f6d3-3eff-4af5-ba62-d6358b11a28b"), Guid.Parse("b882077b-71ad-4940-80e3-f52f5775a297"), }, { Guid.Parse("b3989e91-981e-44e8-924a-f97aa03acd21"), Guid.Parse("40312d73-91e4-4f79-9d9f-a428562cbfa8"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("bf61493d-0f94-4c0a-98cb-f187cd21362c"), Guid.Parse("a6e704b4-ddb7-46d2-a404-c98b784cd289"), }, { Guid.Parse("de9737bb-b29a-4be7-b223-d18ec7521be4"), Guid.Parse("49ea4cec-98f9-4a3d-988d-0dcc176c7088"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("14ed6733-25d2-49a1-a62d-231e095f431c"), Guid.Parse("97941da2-d14d-4c9c-88d9-1cb278248950"), }, { Guid.Parse("3af9e3c7-f823-48f4-910a-fa9206ead77a"), Guid.Parse("a59c4a08-0e36-4f66-870b-da9c32f621e0"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 84,
    Value = 
new System.Guid[,] { { Guid.Parse("6dd2f53b-5452-4c82-90f7-4d0a15ab8c61"), Guid.Parse("13ba85a8-396e-4945-93b9-99f958c6d00b"), }, { Guid.Parse("9c1c8e61-0ec5-4c99-994e-94ec1b6047d7"), Guid.Parse("fedf2dec-e32a-4dbf-b0ef-fe8454c51c02"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 70,
    Value = 
new System.Guid[,] { { Guid.Parse("30041cc8-e905-4059-9be3-4f15a2148102"), Guid.Parse("0ab60bf7-927b-4593-902c-a13d5fd75377"), }, { Guid.Parse("19f33358-a9af-452c-8976-87efb1d00996"), Guid.Parse("0f44e8fe-be15-4a87-a606-35499398ca4c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("286f2244-508d-4eea-a235-d2ea72a73cf0"), Guid.Parse("6167ae38-230b-4a32-95e8-267ac284d70f"), }, { Guid.Parse("f06d7a5e-5754-4d54-ae4b-ac5e7c4f1869"), Guid.Parse("498ed57d-43c6-4fdf-874a-2714e837ed40"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Guid[,] { { Guid.Parse("3607f4bf-e3ee-450e-882f-90fed92d6c9d"), Guid.Parse("6fbf7de1-b646-47b7-a850-74a103c69506"), }, { Guid.Parse("e33958ce-3876-45f7-9bec-2500cc8b086c"), Guid.Parse("0ee76a72-d345-4f41-94a6-4242e1860436"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("112764ae-0e94-4dd3-b1dc-eeeaf16ac167"), Guid.Parse("8cd454ff-6ff5-4b5c-8625-8845f59e8cd5"), }, { Guid.Parse("8b9db7db-4363-4c42-b0ae-af17f2ddf77d"), Guid.Parse("c4d318f2-844f-42e6-b824-4f6238d8e838"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 93,
    Value = 
new System.Guid[,] { { Guid.Parse("03690de7-6b90-414d-a6ba-b985cf4fdbf4"), Guid.Parse("b0e64d7c-d80a-45e9-9bbf-8ae02897c536"), }, { Guid.Parse("d68be887-5cc9-40dd-ac33-d145915e700d"), Guid.Parse("a53a2634-e709-4bfe-a3d8-6f5a179e6e9c"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 80,
    Value = 
new System.Guid[,] { { Guid.Parse("17623b33-1ede-4c2f-9fcc-39a5c79f14b2"), Guid.Parse("84c1d79a-36c9-4e1c-a7b6-37c8a89c1e60"), }, { Guid.Parse("3a245549-b6de-4ebd-b380-05ec6f32be2d"), Guid.Parse("153af6e2-57bb-4cf6-a2fe-c5c45b654b49"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 94,
    Value = 
new System.Guid[,] { { Guid.Parse("f33add3c-c367-455e-9509-9899ddab6cb4"), Guid.Parse("9ca0ba10-39fc-4c8c-b9e5-20a4d6154672"), }, { Guid.Parse("52cb5b40-a9a0-4abe-9677-1f86204c38c6"), Guid.Parse("b83f29f5-4cb3-4031-b3a4-f59301fd61f0"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("96e81874-d23b-4251-9f49-da9523952c67"), Guid.Parse("812e8f28-4a6a-412e-8391-1d647822b213"), }, { Guid.Parse("e68e58db-0378-4c18-b59b-2d6545d7ade3"), Guid.Parse("79cf035c-64a2-4ca1-ad07-906558cbd594"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("78f20920-63d3-4770-b70b-480c37b6967f"), Guid.Parse("1600a348-35bc-4fa6-9535-4962b2cfae69"), }, { Guid.Parse("8ce24f4e-7adb-4e15-abdb-46347f24f253"), Guid.Parse("0b3f8a03-4a70-4396-b2d7-e0c885cc6f34"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("337c3ffb-a7e9-4ae5-a841-90b999274e00"), Guid.Parse("d77161fc-38da-4e8b-ba63-b80f8c024378"), }, { Guid.Parse("ee32584d-e99d-4ad8-8b5a-7cdbb0862653"), Guid.Parse("19d6bf58-9bea-43d6-820c-d493b40e4d51"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 83,
    Value = 
new System.Guid[,] { { Guid.Parse("b8605ca8-711c-4004-ae43-00b3b8e7cf59"), Guid.Parse("c4e8c973-123d-4310-9830-6affad21cf91"), }, { Guid.Parse("4b9e4cf9-1ff8-4320-a62d-69fdb56d9bb2"), Guid.Parse("f7973aff-5b60-49ab-bc5b-2b94c64a24a3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("edd73f31-5cf7-4546-80c7-c62fcbf205af"), Guid.Parse("5ed46ac2-640d-44f2-908a-04c0561670de"), }, { Guid.Parse("591cc85b-08e4-48e1-aa53-a3deaa89aa7b"), Guid.Parse("da5bab18-930f-461c-8f52-a9287cd376f2"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 99,
    Value = 
new System.Guid[,] { { Guid.Parse("58586e33-80e9-4ae4-861f-d03471610de8"), Guid.Parse("1fe6c856-64ec-48ec-b194-580936c7d599"), }, { Guid.Parse("3bc781ba-f0cf-4c7a-9881-0c8680101a7e"), Guid.Parse("df34e0f7-9649-4a88-a392-49675514cc95"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 84,
    Value = 
new System.Guid[,] { { Guid.Parse("7cdf57ba-c241-4c8a-8e95-b5ba7d3564fd"), Guid.Parse("b5fc25e4-cc6e-4614-80a6-d969af029108"), }, { Guid.Parse("58a2e7f0-f96e-40ad-b6ac-3fa3dbf0d556"), Guid.Parse("1e6da090-d48d-485f-a9e7-a96ec850b22f"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 107,
    Value = 
new System.Guid[,] { { Guid.Parse("e6550553-929d-447e-97bd-ee009c787ca2"), Guid.Parse("5f65809f-1ae3-4ab8-b9ca-bb8068301912"), }, { Guid.Parse("44a11c44-ff05-434e-a82e-1d9b907cba44"), Guid.Parse("7a498b82-1c99-4159-bc68-c594deac6239"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 90,
    Value = 
new System.Guid[,] { { Guid.Parse("7236dbab-03e9-4b72-867a-114ce951c60a"), Guid.Parse("dbc84cb0-e1a7-4387-997e-8b8fd7198cd0"), }, { Guid.Parse("38d55ebf-9b3c-4581-8489-feed81c0a1a1"), Guid.Parse("a792c9f6-4951-49cb-9e03-3c140df513df"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Guid[,] { { Guid.Parse("34602ea0-ed02-4eaa-aed7-c064b6d1646e"), Guid.Parse("dc98537f-adec-4505-9752-9c0ff6110c41"), }, { Guid.Parse("dca76f48-d264-432b-bd91-bd360b4f49ea"), Guid.Parse("ac81488b-8014-4485-8028-6f8bd5bec282"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 96,
    Value = 
new System.Guid[,] { { Guid.Parse("9480edd1-1891-4914-b799-6710abb3dfe8"), Guid.Parse("22c13a18-6f7c-4e42-9ae6-a369038840f0"), }, { Guid.Parse("82daf5f9-3f52-472a-87b0-69b08ecee8aa"), Guid.Parse("27987812-78e4-485c-910f-2a3089d43a1a"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("47925e8d-1c83-4d4a-b482-bb3f5e23f6df"), Guid.Parse("723f98b8-4756-4a74-a25c-9d8b0c0906e5"), }, { Guid.Parse("0ad63724-5daf-4d38-8724-8a3739f54edc"), Guid.Parse("988e0bc6-8807-4afe-87af-85e7ab8ab1f9"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("87ab7448-aff6-4b63-821a-1a6921be354f"), Guid.Parse("63ebbb8b-02d2-4a8b-9e1c-997e45f7b39e"), }, { Guid.Parse("af551d6d-fc3c-431a-b7e8-7c05a1d438eb"), Guid.Parse("8e5f6275-5664-40f6-be50-2287496a231b"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 118,
    Value = 
new System.Guid[,] { { Guid.Parse("12e5377c-7be3-48ea-9fb0-2911d67b8327"), Guid.Parse("2d24d981-9c09-444b-99df-b69bc7e1b273"), }, { Guid.Parse("fef88e70-4ce5-4136-b215-929a6164b17f"), Guid.Parse("27869ec3-b3c2-4069-b46d-62e8aac77389"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 103,
    Value = 
new System.Guid[,] { { Guid.Parse("bd4743ab-3ddc-419d-b9d9-9d216909bafa"), Guid.Parse("887bfaa0-61b2-413c-a974-af3b783a072a"), }, { Guid.Parse("fb4de218-e4ad-4d60-9cd8-9e7ef7854ac0"), Guid.Parse("495c5b8d-4d80-41a4-906c-cc8be6f556f1"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("8daa0e3f-a360-4526-a314-47138ad355ce"), Guid.Parse("7321136a-b3b7-4f2c-b13a-63df1008c784"), }, { Guid.Parse("b39b6452-94ff-471d-831b-f192a5eb925e"), Guid.Parse("a96a5922-148b-49da-9524-453189b65553"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 124,
    Value = 
new System.Guid[,] { { Guid.Parse("e9d25a65-8e6a-4951-8ce8-2233527050ea"), Guid.Parse("a6531c2f-02e1-47ee-81ef-737d764be0e1"), }, { Guid.Parse("7c124f53-5a90-4364-aadc-94bfebe9e7b7"), Guid.Parse("b6092bf9-27e3-4107-9988-8079b2eb5d22"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 112,
    Value = 
new System.Guid[,] { { Guid.Parse("f7d5a226-ace3-4e78-a4fa-9b1463c8689f"), Guid.Parse("61beb54a-0d31-4419-b8ff-6458b728d261"), }, { Guid.Parse("d5bd9d3c-cdeb-423c-abbb-3f90ecd344ee"), Guid.Parse("0f5ad7e7-90dd-4646-9af7-c57b83293f94"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("ddf11157-c6e1-4e0d-a33b-d95e9b16e2af"), Guid.Parse("c1654ab7-09ab-4dff-a89a-2816250db2da"), }, { Guid.Parse("c8cbb759-d0d5-42a7-8c83-dff914167127"), Guid.Parse("b33299b4-b882-457d-92c9-4ac4d2c621f1"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 113,
    Value = 
new System.Guid[,] { { Guid.Parse("04148cf1-1969-4792-a027-1a2d03bc4202"), Guid.Parse("04a3989b-29fd-406a-a352-7903effb7033"), }, { Guid.Parse("10ff20b7-62d8-4295-b782-6c39b9296b9e"), Guid.Parse("96d4d3cb-6fd1-4a8d-a76f-8c7526589bee"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("a4151b9d-5e3d-4b7b-969d-8ecddb5336c6"), Guid.Parse("1ee125c9-762c-45c4-af95-51d831a4e4da"), }, { Guid.Parse("29e20239-effb-484c-b6ba-acd45c314174"), Guid.Parse("0395cc65-c4d6-451e-b024-9be6f2a9af3e"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("69cec2ba-9fd0-46ff-b4b5-f59b520a9eeb"), Guid.Parse("4e8e1eac-5afd-46bd-af96-85ef92624603"), }, { Guid.Parse("6b85a676-e582-4dfc-843b-f9e52c4ef6aa"), Guid.Parse("267cade6-f9b3-49b6-89ef-847c72dadc06"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 141,
    Value = 
new System.Guid[,] { { Guid.Parse("2a7d6100-d7ee-49a0-8cfb-1514fb93d8e9"), Guid.Parse("5510096e-262b-4b11-b0a8-131a89318253"), }, { Guid.Parse("2342e2fb-fcb4-467c-a673-38548e3c1b66"), Guid.Parse("bce8139d-b410-4bad-b7f5-2afd4609db75"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 122,
    Value = 
new System.Guid[,] { { Guid.Parse("55598aef-b2b4-4d70-b3b0-41145f6dcd55"), Guid.Parse("35fde7b9-6b52-4da5-8db7-53a942ccac0a"), }, { Guid.Parse("56c63e6e-f654-4e48-a8c5-11f80d2bf2f7"), Guid.Parse("d4bb1b61-bf65-4745-9327-5b441462177c"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 147,
    Value = 
new System.Guid[,] { { Guid.Parse("c348fdd4-7bd0-4aec-b609-caf75e78658c"), Guid.Parse("fd4ed599-ba3b-4832-808a-a959f670559c"), }, { Guid.Parse("03a5a208-ab36-46c4-ada4-db66850e68e4"), Guid.Parse("0860ccca-1106-4ab1-b5f6-4cd9f6228f48"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 130,
    Value = 
new System.Guid[,] { { Guid.Parse("d8045a4a-857d-44d6-92da-e6cf7cf14258"), Guid.Parse("878bfdc4-75b0-496e-860e-bb80568e7a2c"), }, { Guid.Parse("2fb68591-71fa-4a81-8ea0-a1d29d4f14f9"), Guid.Parse("6308f016-979a-4841-8db3-4bd4761b6365"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("084b5d45-4915-4921-82d8-c26cb6e41bcb"), Guid.Parse("1d77f150-79f0-4652-8cc0-5864535a3512"), }, { Guid.Parse("4821add0-76f4-4f39-87a2-4edaae714410"), Guid.Parse("d4e992b6-09c6-497c-8829-231426ae7f27"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("b29cba2d-ee79-4886-898f-7cb05a8443cc"), Guid.Parse("bb5d4693-184f-4d1d-8ca9-2ce65e6e8a4f"), }, { Guid.Parse("4098b672-721a-4375-b455-b29c7e4af3f1"), Guid.Parse("02f21940-b06b-4613-8836-db822ee4325c"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 155,
    Value = 
new System.Guid[,] { { Guid.Parse("b57abf43-dbea-4d10-8a1e-192a63d12045"), Guid.Parse("acf0baf1-c097-4436-b67c-1c4aee5d6931"), }, { Guid.Parse("09b61ca8-232d-419d-8ec9-094c8fa9c750"), Guid.Parse("16cb086c-fdaa-4ba9-96b0-21be04ab3710"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("dd1f49f4-2706-40f9-9984-cc0e1370f399"), Guid.Parse("a790d95d-3fa0-45e3-9a64-236b925950b2"), }, { Guid.Parse("98717823-d098-4222-a84b-c12312f809ca"), Guid.Parse("24a2f11b-3126-452b-b79a-c220d0144f24"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 162,
    Value = 
new System.Guid[,] { { Guid.Parse("adc12e68-b0dc-45e8-aab5-1a5dc0500bdc"), Guid.Parse("85895677-cb75-4a07-9f60-a320eaff85cb"), }, { Guid.Parse("0e9a95c1-85b8-47b6-8bae-3500af8876c0"), Guid.Parse("d727ff88-1356-4cf8-ae75-4089d773325d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 135,
    Value = 
new System.Guid[,] { { Guid.Parse("12c11e8d-8294-4563-964e-369cea5282b3"), Guid.Parse("06c0f990-5434-400b-85ce-16236ad7e506"), }, { Guid.Parse("8079d1a6-ea10-411d-9c3a-e49a763a8e0e"), Guid.Parse("f0bfb907-225a-41fc-af92-34af904867db"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f5f776d7-8fee-45c6-9f35-782c0e98ef66"), Guid.Parse("58941f30-d05b-430e-9ab6-0df94b2cd920"), }, { Guid.Parse("9c3760ad-5814-4234-9295-7f9617098268"), Guid.Parse("7998f043-edbc-413f-9b56-2b75edc16bee"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Guid[,] { { Guid.Parse("cb7bf2f1-7521-47dd-b71f-c87be5c5739c"), Guid.Parse("e001f867-305b-4e42-b206-e47a3bccfcab"), }, { Guid.Parse("9e71d509-bf23-49fc-8a9d-632e6da4103e"), Guid.Parse("2c151a8f-120b-45ef-b01a-3b8aedd0de8b"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 137,
    Value = 
new System.Guid[,] { { Guid.Parse("840d76b0-9e6a-4817-b147-6e914537eb37"), Guid.Parse("e6829a9e-9d05-4c87-944a-36bef1f73842"), }, { Guid.Parse("b960253a-4e12-4d6c-9e18-1141b74685b7"), Guid.Parse("600f221d-9876-4b8d-a823-9a630c8b2408"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("18019414-e80c-4cca-afd4-dbdcf8c5ce65"), Guid.Parse("9934713b-11cc-408a-b675-65ac2373146f"), }, { Guid.Parse("a1acaa20-09fb-4bab-b2a8-774e48681971"), Guid.Parse("8eea7bc5-53b6-41af-a6f1-a65a012c3204"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e6930feb-d69f-46dd-af81-2a2d8fe620fd"), Guid.Parse("992f8fd9-4f3b-4f74-93ae-266183c4685e"), }, { Guid.Parse("c75d1df9-0fda-4ef6-8b57-7ca7329507c7"), Guid.Parse("5c6c6c49-60e6-46ab-962b-5de18cb43339"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 171,
    Value = 
new System.Guid[,] { { Guid.Parse("26853584-ceb8-45a4-a6c9-949920a863fe"), Guid.Parse("e4deee53-4877-4f48-a7ce-1aca0230b4a9"), }, { Guid.Parse("78772418-59ff-4018-9ab0-f0c743899d95"), Guid.Parse("bb0a01a9-adcb-4210-9d1c-9306e0a9b94d"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 143,
    Value = 
new System.Guid[,] { { Guid.Parse("1adaf056-b0e3-42eb-a9b7-a00adfc6d151"), Guid.Parse("c8d1ce3a-9571-4326-bbfc-c6177d02fc0c"), }, { Guid.Parse("11052489-d5a8-41ec-a438-b706039f9377"), Guid.Parse("a0626fe0-9231-40d2-87ea-8bb62cac6332"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("da9fcb91-e492-4119-b150-0cfe8efade1b"), Guid.Parse("08ad528a-3b20-44a6-bf4c-15522b3401ee"), }, { Guid.Parse("be071d36-c106-4327-9d83-25dc912c5d4d"), Guid.Parse("8c82cb3b-70ac-41a0-a468-304855b27506"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 180,
    Value = 
new System.Guid[,] { { Guid.Parse("5bc142de-3534-4179-9f1d-9cfa6124d221"), Guid.Parse("9a649fa3-37cb-42d8-ba2a-2f591e7a2b9f"), }, { Guid.Parse("2f94c7a0-7e87-462b-957d-033133fea79f"), Guid.Parse("4b09e7f0-95df-45e0-9926-778dc72c0b13"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 149,
    Value = 
new System.Guid[,] { { Guid.Parse("a599ad4d-6812-4008-b91a-1fdf0129d78f"), Guid.Parse("74d4db51-7aa7-403c-a7c7-d01bca5b3a10"), }, { Guid.Parse("25579efd-4b9a-489f-9c27-9c3dfc8d9849"), Guid.Parse("b2abdd7d-96c8-4587-a824-de92728db1e3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7de12963-e229-4e22-ba9a-162f68f920a8"), Guid.Parse("a40faf51-720b-44c1-91d6-a74fe691936f"), }, { Guid.Parse("1fbf1b9b-bc7b-4352-86c7-53495a9aaa0c"), Guid.Parse("0357653b-84e1-4e51-b366-61ff275f207d"), }, },
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 187,
    Value = 
new System.Guid[,] { { Guid.Parse("75294747-780b-4df9-864c-f7ad30486fe1"), Guid.Parse("1c97b99f-0674-4eeb-a0df-4167f707004c"), }, { Guid.Parse("ce7c0274-6570-46d4-8d0f-ff54143cb164"), Guid.Parse("14e6444e-14c1-422a-9a8c-132aba0b0aab"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 156,
    Value = 
new System.Guid[,] { { Guid.Parse("b61cff25-9740-4e34-812d-90aea527bfc2"), Guid.Parse("6c1efa88-476d-40ae-8e0c-aceb1edf7d5b"), }, { Guid.Parse("270bf54b-9a37-4f19-ad2b-b2ab2553811e"), Guid.Parse("c94c0bed-c5f4-4075-8667-ecc3ff16d4cd"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7492d491-9644-4af3-a75f-b4c99c2e5ac1"), Guid.Parse("4a4f1f42-9f39-4787-b809-73c0159e4eac"), }, { Guid.Parse("9bc8792e-3f3c-4f31-81a8-5ff56e7de86f"), Guid.Parse("d5e07c7b-58d9-4148-89d2-192ccf0658d2"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("24f181dd-3607-4f7e-8b44-ae928ccf4799"), Guid.Parse("b1f6229d-5aa5-426c-a576-bae0c1c4a55c"), }, { Guid.Parse("ec7c1690-baa4-44dd-ab42-ffbd813a30b7"), Guid.Parse("2d42e819-3a14-468d-8687-bb30bb33bed0"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 188,
    Value = 
new System.Guid[,] { { Guid.Parse("65d4d6b6-4f98-4fb3-8191-3ae183c0ff29"), Guid.Parse("d7435d0f-ce34-4271-be4f-7947b3cd196f"), }, { Guid.Parse("2185cf07-f020-45f8-9239-9ffcf083409e"), Guid.Parse("71ef841f-794f-4939-9df7-bbb0b800bc58"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 159,
    Value = 
new System.Guid[,] { { Guid.Parse("05a235d4-5c6a-415a-8f5f-813bc3af22ad"), Guid.Parse("a03c74c5-c9ad-4475-984e-b5d9b1748d04"), }, { Guid.Parse("3b4fb25b-d826-40bc-8048-2f50627ba6c2"), Guid.Parse("4f6383b5-86c8-4239-a32b-81e91b14a805"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 196,
    Value = 
new System.Guid[,] { { Guid.Parse("2d7b3c18-b06d-4e02-a425-6a1e647b6dc2"), Guid.Parse("cbef2fb0-3cd7-410d-a35a-03551adf8d04"), }, { Guid.Parse("f1f18199-2cf8-4b3c-badf-2df22ff028f3"), Guid.Parse("5538b49a-72b0-41b4-8a57-b41f487e675a"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 165,
    Value = 
new System.Guid[,] { { Guid.Parse("85061214-9ff1-4abb-b82a-d7659a8e5e06"), Guid.Parse("edc7754e-2d19-4f46-b037-40daacacd15d"), }, { Guid.Parse("01428d2a-c16e-43d8-838c-bde512e38e23"), Guid.Parse("39c77802-8fe6-4714-aca7-fee38572d0a6"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD2E1M
{
    Id = 198,
    Value = 
new System.Guid[,] { { Guid.Parse("dd57702c-9413-44ed-961d-0f4e53bb69d6"), Guid.Parse("e59fc2ea-7ce7-4b17-8df5-cf755b599029"), }, { Guid.Parse("7f1c0579-e0b2-410d-a353-e99a1cef85f7"), Guid.Parse("ab1f749c-1d57-44f4-892b-0f22aeadba24"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 170,
    Value = 
new System.Guid[,] { { Guid.Parse("97d60a39-b8c5-4780-abb4-992fa6495c11"), Guid.Parse("a7cdb883-7b13-49fa-8cec-1346a756091a"), }, { Guid.Parse("3b03a7af-1f1a-47de-90d1-258c5b5a31d8"), Guid.Parse("6f98e3e3-cc96-40e9-84e5-d4b23c53c0d9"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("714936ed-ba75-4c8a-bda5-edbd8786d541"), Guid.Parse("05626c30-a4b1-4b5a-af25-5a4cccecc9df"), }, { Guid.Parse("1e7e18e9-8b7a-4f8c-95a8-a15427c65b73"), Guid.Parse("6b41a198-a0ca-4887-a176-b18fcacf08b6"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 203,
    Value = 
new System.Guid[,] { { Guid.Parse("622798a3-b973-4aa2-9852-376301c1a965"), Guid.Parse("0caf1804-b30f-42c4-b1c3-fdf650d66c4c"), }, { Guid.Parse("7b65b27f-a1a5-4853-9f74-ddbc8b148778"), Guid.Parse("b59ab685-7630-4d0d-bc55-00004dedf983"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 171,
    Value = 
new System.Guid[,] { { Guid.Parse("7d8a2e1d-3366-482c-98ed-c9178c450252"), Guid.Parse("d9cc95d8-c2f1-4f2c-ae58-bccd366a7d82"), }, { Guid.Parse("e9d51596-c78f-48e2-8598-34fe2b31663a"), Guid.Parse("fdc3995e-2c43-4aea-9b27-ab827f13e2b8"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4b885af8-ea64-4a71-8cb1-0dd377468d88"), Guid.Parse("dbf69d48-7132-4b52-a927-10c803d338d2"), }, { Guid.Parse("77c678da-ce14-484a-858b-e51ff8c37c05"), Guid.Parse("adfed531-52fc-4d73-b633-2d51d4643b51"), }, },
},
            new GuidMArrayD2E1M
{
    Id = 205,
    Value = 
new System.Guid[,] { { Guid.Parse("84b994ca-c571-46e3-aa40-c15c89241733"), Guid.Parse("663f796e-8155-4a26-8759-8ccd880a9f1e"), }, { Guid.Parse("4b7f5815-5572-40c1-8504-1af8ec1eaccc"), Guid.Parse("b30d038d-d41a-4a1f-898a-737f657b7ca8"), }, },
    ModelInner = new GuidMArrayD2E1MI
{
    Id = 173,
    Value = 
new System.Guid[,] { { Guid.Parse("96056e35-8312-497d-9fc4-35fb616b22a2"), Guid.Parse("e10496b3-48b4-476a-a027-fae4e6f81289"), }, { Guid.Parse("411a15f1-8947-43ab-8b7b-238c400abf4f"), Guid.Parse("e60b462d-655a-4421-b934-fc7f06c07aeb"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidmarrayd2e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(Array(UUID))}, 
    {mi_id:Int32},
    {mi_value:Array(Array(UUID))}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[,]), 
                parametrName: "mi_value", 
                methodParametrName: "mi_Value")]
        public void InsertModelDbConnectionConfig()
        {
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < 2; i++)
                {
                    await ((IGuidMArrayMArrayD2)this).InsertModelDbConnectionAsync(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

        [Test, Order(1)]
        public async Task InsertModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 2; i < 35; i++)
                {
                     ((IGuidMArrayMArrayD2)this).InsertModelDbConnection(
                        connection,
                        m_Id: _testData[i].Id,
                        m_Value: _testData[i].Value,
                        mi_Id: _testData[i].ModelInner.Id,
                        mi_Value: _testData[i].ModelInner.Value);
                }
            }
        }

#endregion

#region Select Models

[Gedaq.DbConnection.Attributes.Query(
            query: @"
SELECT
	m_id AS id,
    m_value AS value,
~StartInner::ModelInner:id~
~Reinterpret::id~
    mi_id,
~Reinterpret::value~
    mi_value
~EndInner::ModelInner~
FROM gedaqtests.guidmarrayd2e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD2E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD2)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_id")]
        public void SelectModelDbConnectionConfig()
        {
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTestAsync()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models = await ((IGuidMArrayMArrayD2)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

        [Test, Order(2)]
        public async Task SelectModelDbConnectionTest()
        {
            await using (var connection = GlobalSetUp.GetConnection)
            {
                await connection.OpenAsync();
                for (int i = 0; i < _testData.Length; i++)
                {
                    var models =  ((IGuidMArrayMArrayD2)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD2E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

