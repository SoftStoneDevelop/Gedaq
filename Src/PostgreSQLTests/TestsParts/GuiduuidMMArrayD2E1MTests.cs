

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
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("a470bdfa-8dcd-4990-925b-6b3a454eee25"), Guid.Parse("2cd6805c-46d4-4ef2-b7b1-2b1f6ada9b2d"), }, { Guid.Parse("d9d6cd42-9166-402e-a517-9413a4b82f9f"), Guid.Parse("8f88d2e6-b37c-4f84-9ce9-3e6dd8ed2036"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4ce1f9da-766f-46bb-b80c-7811fb2b08dd"), Guid.Parse("31fe87ed-048d-4a25-af8d-9a328eed2ab4"), }, { Guid.Parse("e6e4a31a-d7b4-47c8-af3d-87c366fea7c0"), Guid.Parse("500cdb79-0bf3-4b0e-a4e9-396848220129"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 12,
    Value = 
new System.Guid[,] { { Guid.Parse("6a9273ac-25d6-48a1-a79a-c815936bf277"), Guid.Parse("5d8b0694-5612-4a9f-95f4-69731f440868"), }, { Guid.Parse("27038842-aaa4-40eb-8ced-3c1ef92c778a"), Guid.Parse("89daf02e-ebde-42e9-a970-26a93147aca3"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 8,
    Value = 
new System.Guid[,] { { Guid.Parse("4c416b41-9bac-4684-8ccc-a41441226e6f"), Guid.Parse("4e80ecc0-1edb-4117-9976-6524d151ebb4"), }, { Guid.Parse("7d2193f3-9dfe-4eae-bba5-f396d9a5b29a"), Guid.Parse("fd75f4a3-3317-4f3b-97da-89dd0242a3c4"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5144da2a-552d-4e17-959d-b2ab2e07fcdb"), Guid.Parse("f4fcf0f6-1bf5-4559-a969-8fef6f9fbe57"), }, { Guid.Parse("08163640-b306-4d0c-9eb5-bd717be09194"), Guid.Parse("c48a1396-316b-410c-82ad-3bdee4010869"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("4358b117-69e6-4b8f-9e1d-b5092bee14c0"), Guid.Parse("0b2967ee-27df-4e66-8a10-38833dbc7146"), }, { Guid.Parse("36a316ea-20ff-46b9-a996-6052520c3a4c"), Guid.Parse("60bab52a-c9d5-4bb6-a721-da18eae484d2"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 17,
    Value = 
new System.Guid[,] { { Guid.Parse("010d669e-3944-40a5-8e55-0f43f1b9405c"), Guid.Parse("1bbd4f4b-fce6-4093-8b6b-8c674426a9a7"), }, { Guid.Parse("4d5eff55-4481-4960-a6b5-a521d3931493"), Guid.Parse("c51da1b9-7ed1-454e-8cac-e0948e3b6017"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("7dab5b9f-d121-4f7e-af00-c6fad0e65610"), Guid.Parse("b1519b31-f90d-4eee-9a01-bb15dc185021"), }, { Guid.Parse("86b2ea05-d87d-4aec-9cad-f3a91f5aebc0"), Guid.Parse("01b5873b-e80c-425c-813e-59da1b33e672"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 18,
    Value = 
new System.Guid[,] { { Guid.Parse("197c4422-b9aa-488b-a6b9-fb4ce7917e0a"), Guid.Parse("59662baa-2a91-498e-a056-fdb3f4d25988"), }, { Guid.Parse("315fe749-8882-4c0b-aa61-e288c5122310"), Guid.Parse("163679a6-d16e-4bf8-b51b-812bbee07b25"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 15,
    Value = 
new System.Guid[,] { { Guid.Parse("8447c1b5-870f-4856-83c5-ebb485257e7e"), Guid.Parse("3e1d86d6-e4c5-48e8-a807-1c3988eb76ca"), }, { Guid.Parse("7726eadb-57d8-4bb9-b31d-d472d923f6ce"), Guid.Parse("87e2cb8f-3061-4d35-8299-76647cf1b390"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("d91a45c3-9ba2-4e98-a626-08ff97eebe6d"), Guid.Parse("88e6779a-2273-4d25-9cb1-7db860fec4aa"), }, { Guid.Parse("a7f3b1d6-55ef-4a7e-befc-bfe242e33543"), Guid.Parse("90e4f672-11c2-4a28-8d37-26c3ff280d34"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("49a51222-cb33-476a-b86a-beb04e497afc"), Guid.Parse("a079d07d-4b0d-4ae1-94a6-e225ee9bbeb2"), }, { Guid.Parse("6a8ca4d1-9c16-4722-9859-12b6de119770"), Guid.Parse("c28a8c73-a393-4e86-b123-4340026b0536"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 21,
    Value = 
new System.Guid[,] { { Guid.Parse("de19e438-ea76-41ab-a43c-ef0fb0d749aa"), Guid.Parse("5e25180c-62aa-48f7-9495-4fa66e8846e9"), }, { Guid.Parse("be2e7509-98bd-4643-be81-1ee9f2744945"), Guid.Parse("6ce8bd51-7071-4575-b66c-7d8fb644494e"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 30,
    Value = 
new System.Guid[,] { { Guid.Parse("6edd0efc-dfff-4be6-82cb-e028609ca7ea"), Guid.Parse("3267015e-55af-4f76-896f-832dc827d27a"), }, { Guid.Parse("371e9fc0-d4f0-4802-b23a-b4cd8f5039f4"), Guid.Parse("11319641-6551-423e-b3c9-0dab0cbc79b7"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 18,
    Value = 
new System.Guid[,] { { Guid.Parse("7183b222-5aea-4db0-bcc2-e0b2dda23329"), Guid.Parse("009bc755-08eb-4531-9c13-9427f9627681"), }, { Guid.Parse("85af0a39-5734-4591-88d5-f1d6e84b7631"), Guid.Parse("42d01fbe-a35a-459e-8b73-08be4c8f1e12"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5c846a26-2902-4e12-89b8-fdd9250478c1"), Guid.Parse("7879264d-077b-4ca2-a907-16ebd24b15bd"), }, { Guid.Parse("c69e7c2b-91f1-4349-a5fe-1d044758feb0"), Guid.Parse("e461ac03-964b-4b5e-8996-62052cf88d2d"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 34,
    Value = 
new System.Guid[,] { { Guid.Parse("50397929-581f-4968-9aed-6d403974d4d3"), Guid.Parse("7cc0de8a-e260-4a25-bd3b-0852a02e7187"), }, { Guid.Parse("441a4965-b62d-4e2e-9299-32ae16e00e1e"), Guid.Parse("9cb940b1-9520-4c0a-9a45-c86053d06407"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c42b7fb6-b153-46cc-8074-13a7e4db6b07"), Guid.Parse("8dc00ea2-6a47-4ca2-885d-b8020c0de9e1"), }, { Guid.Parse("f1ae37fb-dc23-4118-9a0f-5ce7d2b203c9"), Guid.Parse("e9627b8b-e597-4a6a-a5df-dae0c2e79acc"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 36,
    Value = 
new System.Guid[,] { { Guid.Parse("9edd69fc-baba-4ea3-ba37-dec7e3b7d2df"), Guid.Parse("b58daa54-4f67-46b0-8726-4454c3d24615"), }, { Guid.Parse("9042b19d-6d84-49ef-9926-b794be4bacd3"), Guid.Parse("b2c4ca39-ec2d-4f98-8105-b046dd467f94"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 22,
    Value = 
new System.Guid[,] { { Guid.Parse("7bc8690b-ed66-49b9-a3ae-a781d0a99601"), Guid.Parse("b3c2ebb6-e1d5-4d3e-a4c8-e3cd4505cfc3"), }, { Guid.Parse("079ddbf1-018c-4a2e-b38b-a8777e91ca28"), Guid.Parse("4d2c42f2-316c-4fa2-88bd-86c23fa0b055"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("2877f5cd-28b8-4a26-815d-34965cdca5b2"), Guid.Parse("4f2e363c-1ed7-4cb0-97a4-2c008b814457"), }, { Guid.Parse("284ff655-8a6d-4ba8-939d-6e7382b6bd09"), Guid.Parse("882fcc50-e41b-4292-b80b-239ba2f8f9f2"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 39,
    Value = 
new System.Guid[,] { { Guid.Parse("77721b08-cc96-4f80-aeac-0715fe80535e"), Guid.Parse("21f8b28d-07de-4802-9130-06e97a978355"), }, { Guid.Parse("dd697418-ae3e-4198-89d4-6ab7f563121e"), Guid.Parse("0da9687e-13d6-4119-8fda-7b5d8d6b46e7"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0b085253-c3ae-4b11-836f-05908d23b234"), Guid.Parse("5a9f3fe3-a3d8-4651-869d-66097c1251e3"), }, { Guid.Parse("3f4d8ea7-a022-4922-8168-8f00e6c70770"), Guid.Parse("55ea94f3-4972-4a04-96e0-c9bdf2322f4c"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 47,
    Value = 
new System.Guid[,] { { Guid.Parse("3b016e46-68f3-4437-bde6-be27056a221f"), Guid.Parse("6b027857-9a79-4ca0-9a4b-fb6b5109ed1d"), }, { Guid.Parse("f6c73460-6dc4-45a7-85ae-4bab081af8ad"), Guid.Parse("72f6942e-4d9d-4c88-a559-ed2e0b7aad86"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 27,
    Value = 
new System.Guid[,] { { Guid.Parse("41d68118-cc60-4c20-b21f-e727edf84771"), Guid.Parse("915c0f06-5baf-48eb-801a-e9473ee39dbd"), }, { Guid.Parse("7b398b01-c680-4f75-8a4d-6c31a924767e"), Guid.Parse("50c0f0be-2039-45b2-9588-b3910e87041e"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("357913d4-d306-443c-8389-aa983dd5fbab"), Guid.Parse("8c47d828-cc3c-445b-be28-f3bcb99b1e4e"), }, { Guid.Parse("d5b1b43b-f487-4330-b3dd-d0ab4b4bf4d8"), Guid.Parse("e826f50c-b082-40aa-bdaf-1bad59441855"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 53,
    Value = 
new System.Guid[,] { { Guid.Parse("03398471-3c01-445e-9241-950bd525fc9f"), Guid.Parse("e0808517-8f23-45bb-a614-6ff58b7fb453"), }, { Guid.Parse("fc35d07c-5dcf-4230-bec4-3b068e13ac02"), Guid.Parse("cbc1ec84-6e1e-4e03-a9c9-5c175ec7c286"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0d0d4462-16db-42e0-a110-9ea943a2eb3e"), Guid.Parse("ce768e7e-52c7-4194-83a0-0a6198c539e1"), }, { Guid.Parse("4f8bfdf5-d54c-42c8-9e4e-2f2278cc9e91"), Guid.Parse("4d0a4824-a844-4d75-a48c-c22790998bc0"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 59,
    Value = 
new System.Guid[,] { { Guid.Parse("80015009-a290-40b3-acbd-3546bcf33e35"), Guid.Parse("77e09463-5767-419e-8850-b1627fc870ce"), }, { Guid.Parse("ec7a4c33-e85b-4cfe-98d3-15ce1676682e"), Guid.Parse("0b8ea1de-4ba9-493b-8e80-83ea631fc2a3"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 34,
    Value = 
new System.Guid[,] { { Guid.Parse("132a0045-1f74-4267-8e03-bddf81ae5964"), Guid.Parse("f2d86faa-b747-4174-9d71-31d8ebf93539"), }, { Guid.Parse("8347896a-5ce3-4a71-abb6-64603ea03fcd"), Guid.Parse("efea3f81-0f7b-4a21-b72d-d19a09b5cdde"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("874b2f9b-b826-4daa-a2c2-b2f2bebc3225"), Guid.Parse("2c3652f6-8aaa-4ad2-849e-b8f6092cea11"), }, { Guid.Parse("b0c87e29-2d75-4654-88a1-4a3c32d49704"), Guid.Parse("0f1922a6-d966-45fa-bb54-21094cd4f00e"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("62071a0b-ccab-4d82-9afd-2168370e9ff3"), Guid.Parse("f910b1e5-8013-407b-8732-76c0dd652ff3"), }, { Guid.Parse("b75e58e3-4499-4a34-898c-68bd65091242"), Guid.Parse("2b7e544f-e7fc-48d5-83fd-10ec3fad1643"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 65,
    Value = 
new System.Guid[,] { { Guid.Parse("b54cb73d-8964-4ece-8a77-007c0dbb3104"), Guid.Parse("f6239f75-87f4-40ee-a3ff-c188d5ddb9f4"), }, { Guid.Parse("32320588-61c5-440f-baad-feeb5b62e4a3"), Guid.Parse("3922a92b-9ff0-4329-ad75-7aef188274e0"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("19d4708b-c81d-47e5-9f9d-20ba335dba51"), Guid.Parse("5cf5baae-75e1-4b59-9e1f-f0c18b916b30"), }, { Guid.Parse("62049a5b-c59b-4dae-b693-e40112e8b8da"), Guid.Parse("c7e0de2b-f3cb-4041-a8ec-772c3bda9b9c"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 73,
    Value = 
new System.Guid[,] { { Guid.Parse("ca97ea52-7632-4bb3-976d-5c2098ed5a3c"), Guid.Parse("6b92a157-c97f-4da7-abb7-d3c801a3b04f"), }, { Guid.Parse("7ac88846-af16-4247-89ae-b65e4ef02d68"), Guid.Parse("36dc2d1e-7d2f-4844-8b2a-e71b235e26a7"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 38,
    Value = 
new System.Guid[,] { { Guid.Parse("dd41f1b4-df21-463f-be58-74aa4e470cca"), Guid.Parse("8cd0e453-1b1f-44ba-9212-6214f0dd99ab"), }, { Guid.Parse("df91deb1-d500-43f1-9d67-d337a91253dc"), Guid.Parse("62f03c60-aae4-4671-8d61-0acdb396f87c"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("5cb2e136-3344-4816-ba5c-46aba46ebabb"), Guid.Parse("711b8d09-cdab-423c-9a52-23685d3b72be"), }, { Guid.Parse("2959c89a-d269-4fa7-ae85-b06c5aad31ed"), Guid.Parse("c4fc3e6f-94ce-4feb-bcdd-1a8fa1de42ac"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 74,
    Value = 
new System.Guid[,] { { Guid.Parse("9d81e180-aa82-4911-8f5f-3d06aa6c5bbc"), Guid.Parse("8e233fba-524b-42d2-a69b-23b2726a4a58"), }, { Guid.Parse("ed2e231c-e0e3-41bc-b077-30ea0816a76e"), Guid.Parse("14a537e6-d65b-4bec-8010-294f4149aed3"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6c3c4d8b-fe50-43ae-93e9-ec828e0c1310"), Guid.Parse("78b36ab7-167c-4f2f-bdb4-45b5d7fd2a82"), }, { Guid.Parse("d0280973-0881-4ec7-bee2-bf08a3417c70"), Guid.Parse("06d91cf1-166f-4c1d-ad38-b269772cdba9"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 79,
    Value = 
new System.Guid[,] { { Guid.Parse("61d8de15-b1d4-401c-9ba9-8b19f9ba0988"), Guid.Parse("fa7c0998-282d-4202-bedc-b4dc6cc2d3a5"), }, { Guid.Parse("aa9bc520-37a3-4359-b1d8-17871ba7014d"), Guid.Parse("0d18ec92-8325-4a6e-976a-e93d05f4d82c"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 46,
    Value = 
new System.Guid[,] { { Guid.Parse("4a2e405e-eb5a-4c8f-a135-70bc5d786c64"), Guid.Parse("318e0439-2e60-4aac-9be0-2e2265e30abc"), }, { Guid.Parse("a0d25213-8839-43ae-90ca-b86ad281d8f9"), Guid.Parse("8a68e38e-a95a-48d7-ae8c-c7a6dadda1c3"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("e1757fa5-ce19-48c3-8060-ad790552fd8c"), Guid.Parse("f84b2a42-603e-496e-99b7-432e3aa2fe82"), }, { Guid.Parse("b616be03-041a-4aed-b0b2-63373b25f3d5"), Guid.Parse("7cf50f21-ad74-4bb5-a00d-96e23d1a380a"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("4df52163-799e-4082-b671-99c9d992d001"), Guid.Parse("af537179-6a1f-466e-8752-46cee9a68cd6"), }, { Guid.Parse("ae7b0204-f6b4-4f24-aadc-1f8fa30be2b8"), Guid.Parse("5d871698-b594-4d19-b240-2155398eec36"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0fb157e0-9340-43d2-8b28-562d0b4c8cf4"), Guid.Parse("d2fdb3f4-9fcd-42bd-a1de-3a3a734537e8"), }, { Guid.Parse("2a0ab47e-6e7d-4df3-9e16-84acc5d0bb48"), Guid.Parse("de198fa8-d899-4aec-bd5a-8fbf987629bf"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 85,
    Value = 
new System.Guid[,] { { Guid.Parse("3aa61494-c1fb-4977-ae49-3ee04a727bbb"), Guid.Parse("f0a813e0-4a13-4c10-a753-0cd98a9106ed"), }, { Guid.Parse("48476c41-de73-4846-8919-762277aaf5ff"), Guid.Parse("ebf87418-5268-4565-98fc-56e74058aa04"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 55,
    Value = 
new System.Guid[,] { { Guid.Parse("0055c902-d6cd-4b47-b3fe-1ae75aca275e"), Guid.Parse("91bf71d9-24cb-4463-8833-c3e80e7fbfbb"), }, { Guid.Parse("23077e3d-c0f3-4f1c-8026-3eec1c9d34f2"), Guid.Parse("989a0a05-0b2d-44c2-87ff-eab4c421500d"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("97ee58a2-248f-4204-bd52-4690e64c92ae"), Guid.Parse("9def90d8-384f-425c-910b-e7a5a6a85593"), }, { Guid.Parse("66e396fb-38a8-4fab-bdda-9bdfb100bcbf"), Guid.Parse("a4557a54-264b-4bb7-bbf1-f10282fcb5d1"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("065d4f32-7b5f-41ab-aaa9-7f89d7cc0e6b"), Guid.Parse("7bc56f9c-d83d-4711-bd4e-5d0b08a98282"), }, { Guid.Parse("9bc042f3-c62d-4bc2-96d8-ccb9d480f7b8"), Guid.Parse("9385532e-eb7a-47c7-a43e-65e0b1f78935"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 87,
    Value = 
new System.Guid[,] { { Guid.Parse("66a60a44-8ef3-4456-b3ec-5e4200ef1127"), Guid.Parse("9c0ddc8e-bbab-43cc-a9d3-80a460d46cf2"), }, { Guid.Parse("fd149c08-b3bd-4e3e-b533-cf642021ab1a"), Guid.Parse("b4330b6b-69f9-43d2-ad88-2ae8be473db7"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("0ec69372-d3ad-49c0-bb49-5591f1799fc5"), Guid.Parse("532df9a5-bf6f-4ee4-ba88-798129d94140"), }, { Guid.Parse("d304b53b-3334-4a59-af22-964b7d25cf99"), Guid.Parse("f85b5b51-b878-4c42-b8ba-a6321473212f"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 92,
    Value = 
new System.Guid[,] { { Guid.Parse("db33420d-b39f-4fd8-bf62-63a106cce9f9"), Guid.Parse("52df015b-1355-444e-9c1f-d64fe3437ad0"), }, { Guid.Parse("9b021087-abeb-4928-985d-765f7b242d27"), Guid.Parse("44ecf7da-8fc7-43ed-9a90-bfb18c482678"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 60,
    Value = 
new System.Guid[,] { { Guid.Parse("2c5f4930-9a4c-4c92-9d96-40f10556042c"), Guid.Parse("9d77a4cc-ab03-4db5-9ac2-b3fd316aff4c"), }, { Guid.Parse("09356a3b-3a00-4785-a567-e62a8e906c7e"), Guid.Parse("6fa9c58e-0be6-4323-bb4e-76317f1c2933"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("98987a5c-d653-4573-96a9-c8d33cbd1fa2"), Guid.Parse("f2bc7439-b574-4684-8bd3-46451c757a02"), }, { Guid.Parse("ee5d8f36-fc96-4ab7-8983-590f9fa87025"), Guid.Parse("eb05174f-a7a1-4cf0-b28b-db0f1313cdbe"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 98,
    Value = 
new System.Guid[,] { { Guid.Parse("022d5557-ce71-4b08-b080-a0b28fa3928f"), Guid.Parse("1b49fb0a-46a3-42db-987f-afcc152853e0"), }, { Guid.Parse("c88ce5bc-f125-41b5-97a7-e1d45e5970fb"), Guid.Parse("8281eb6b-5b84-4ed1-8637-581ff7af83ed"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 106,
    Value = 
new System.Guid[,] { { Guid.Parse("fe78e0b5-ce97-41be-9dd3-377016518af7"), Guid.Parse("eceaf942-9b39-4a73-820d-de9503197536"), }, { Guid.Parse("9dc3daa6-def2-48b9-b2f7-125d50283150"), Guid.Parse("11ee96ad-bba3-4a19-9199-a9be62204682"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 64,
    Value = 
new System.Guid[,] { { Guid.Parse("f7675b4e-2879-41a1-aac2-e1aae1a46317"), Guid.Parse("e6393b2e-64be-412c-92df-affc0829a67a"), }, { Guid.Parse("7189ff37-00bd-494e-b3e4-8110a58957fb"), Guid.Parse("226e269d-7007-46ab-98a9-3702ab4d4489"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 113,
    Value = 
new System.Guid[,] { { Guid.Parse("37fea067-d58d-449a-988a-d233446a9db6"), Guid.Parse("be3bbf8d-418c-4a62-a904-cdbf04b0bc12"), }, { Guid.Parse("db1e917e-005f-4a42-a37e-0bc4d230ddf4"), Guid.Parse("89e9655c-8fb0-4d69-b2a6-9718fa7b8416"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 114,
    Value = 
new System.Guid[,] { { Guid.Parse("4ff8db98-ee83-4ca3-bcf0-55e630a0196b"), Guid.Parse("7cc0816c-4eb2-4473-8137-0e24f6cb915b"), }, { Guid.Parse("c294d496-3b10-4e48-aad1-277384beb727"), Guid.Parse("aabd6f19-97b1-4d22-ba4a-ae08e6274d7e"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 67,
    Value = 
new System.Guid[,] { { Guid.Parse("3936aec1-2a9f-43ca-8238-1e05fce8560b"), Guid.Parse("f442d4a3-1259-4908-b55d-1dc9d9ee81dc"), }, { Guid.Parse("c05a407e-d6de-4c05-a9a6-7cb3cfa963da"), Guid.Parse("a8370fae-bc72-48bf-96bf-3186af8b8e4b"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("bb528ebe-d311-4e71-8478-fee4813bfbde"), Guid.Parse("e1ce1d64-ef32-4352-96ad-46bef9871b13"), }, { Guid.Parse("98a59f4b-654f-4662-9f10-db21732c36c7"), Guid.Parse("4480363c-da2a-4e9e-ae85-743c87ef46b7"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("69a8b0e6-a086-40f7-8da9-8fffb912fbc3"), Guid.Parse("807b5d88-db41-40ea-8123-a05f4dba5a42"), }, { Guid.Parse("09c669b7-d983-4dfe-b297-9843d6ab4443"), Guid.Parse("07160982-55e7-47f8-9793-8842a5f32cc3"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 119,
    Value = 
new System.Guid[,] { { Guid.Parse("eee8df25-5019-4a18-874f-5fa5f6a04521"), Guid.Parse("753bf689-46eb-48ac-9c41-db09f22a1dd4"), }, { Guid.Parse("d871ff46-9991-4b00-9f19-351f1f6347f3"), Guid.Parse("b65a6079-3d5f-49b4-99c8-901428da2977"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6a9b2958-825a-4c62-b2dd-fc23f03768be"), Guid.Parse("00beb76f-217b-4594-90cc-3a4656f28b73"), }, { Guid.Parse("098823aa-0d8f-46cb-a192-ed53984eb256"), Guid.Parse("3efc4820-a30e-4c47-96ac-c4c4ed419a93"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 122,
    Value = 
new System.Guid[,] { { Guid.Parse("e0b969ca-e21e-4e08-afc6-638ecf2291bb"), Guid.Parse("da106f2a-69f9-42c9-9b1a-e3c8eb196fc2"), }, { Guid.Parse("e2041804-34a0-4e71-9270-cfe732d451be"), Guid.Parse("927278a5-ecdf-43af-ae3c-ed928fa02e25"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 76,
    Value = 
new System.Guid[,] { { Guid.Parse("c548bca2-2ece-46f7-a4a8-cea6d7b49342"), Guid.Parse("731aeeb1-6ec3-470b-9fda-ec3ee03ebdea"), }, { Guid.Parse("cb67133a-4647-49b8-bbe1-1911289c67c3"), Guid.Parse("2d5f0a05-0b43-4be6-8d7b-bf9f604dc5b3"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("f822ed52-e406-4151-a0e4-98dcd4f808f8"), Guid.Parse("cc547a3f-d4e7-4bab-96a1-636200b0915f"), }, { Guid.Parse("4c716155-f2ef-45b8-b174-7a8583323ed7"), Guid.Parse("6f69fe8d-63fc-406b-8bbf-c60bafbf2f58"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 131,
    Value = 
new System.Guid[,] { { Guid.Parse("9fb3a2dc-71b1-4d99-9c27-74c0985c8e37"), Guid.Parse("ee1ad169-e461-462d-ad2e-c56d47f472a3"), }, { Guid.Parse("61d9840d-9e9b-4aff-93fa-0ef32bbb302a"), Guid.Parse("04097a30-4f29-4433-aa99-d9454a7bf525"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 132,
    Value = 
new System.Guid[,] { { Guid.Parse("e8fe0656-ce7d-4c42-9ddb-ccd2c148a510"), Guid.Parse("1a7b8e79-e31f-4d1a-b12e-3a258263972a"), }, { Guid.Parse("e2357b7d-0daa-4f5f-b7b0-f77217e95e29"), Guid.Parse("79977c8c-4bf4-469d-a021-2f6d3bc83785"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 81,
    Value = 
new System.Guid[,] { { Guid.Parse("da33e463-560d-4037-8e48-063be6a193bf"), Guid.Parse("d197fd2a-44e5-4666-a968-cf565523ee66"), }, { Guid.Parse("be35b76d-9898-4ea7-a8c2-000490833ddf"), Guid.Parse("3a1415d1-383c-431b-81a1-c97d49f204b1"), }, },
    NullableValue = null,
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("cc3de3a7-06cc-4874-9fd6-15e10bf82088"), Guid.Parse("b2ff7858-2d36-4c99-a03c-d98ab02eb1a8"), }, { Guid.Parse("f5504aa6-8f61-47b3-b694-64667a46cfca"), Guid.Parse("72f1656c-7ac4-4987-951b-9af7928f2a43"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 136,
    Value = 
new System.Guid[,] { { Guid.Parse("7520436f-b69d-403b-a48c-761a620a0628"), Guid.Parse("7ae33db4-36f8-4fc7-a720-908890da7044"), }, { Guid.Parse("58f60e13-3aab-4c2a-9c64-3e45d7382ec6"), Guid.Parse("3967f652-ec7f-4035-8d0a-04bef186bf10"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("c1490806-0b6b-4985-b271-d78ea3a7aced"), Guid.Parse("ea33370a-0b24-4211-8621-292e87864611"), }, { Guid.Parse("cbae82b4-0bef-478b-bbfe-65519fcfe34b"), Guid.Parse("d1ff100e-d42e-4334-b635-e6ed35adecbd"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 143,
    Value = 
new System.Guid[,] { { Guid.Parse("aa2c9cfd-63b3-40a2-bd43-a12762fa7dd4"), Guid.Parse("6e27b097-4a40-4e67-8e07-5d11e8813b1e"), }, { Guid.Parse("472ef799-ba46-4f8e-a795-9a91cba94960"), Guid.Parse("06a7f142-512b-4c92-b690-7210a7f6cf3a"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 89,
    Value = 
new System.Guid[,] { { Guid.Parse("a315da38-91ed-4391-bc32-1ee3a5fa52ce"), Guid.Parse("6c111bc5-9f3a-4231-a0c4-51d3bf0682ee"), }, { Guid.Parse("af0347eb-7016-46a5-a52c-6fe6fa55aa88"), Guid.Parse("f36a14b0-d164-4b48-a783-95242cb43bf7"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("43a3e4bd-a0f9-4750-9f49-1be055ee35fc"), Guid.Parse("000e02fc-227a-4914-84d7-b8371603287f"), }, { Guid.Parse("7d7a2666-4ec9-4956-b97d-5ff17be90e3a"), Guid.Parse("2bea871d-d059-45cb-ac42-0fffb142e5f8"), }, },
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 151,
    Value = 
new System.Guid[,] { { Guid.Parse("4a0da83e-9936-488b-b132-5a19e84079cb"), Guid.Parse("6f15ec2b-85cb-4ea7-9387-075ce1824b88"), }, { Guid.Parse("162d64bb-70f1-4e21-aabd-1fbe88739e84"), Guid.Parse("215cbdaf-ac94-4cb6-9f31-91ef1c384ca8"), }, },
    ModelInner = null,
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 153,
    Value = 
new System.Guid[,] { { Guid.Parse("5cee551f-c4a9-432b-a62b-8bfedb10c171"), Guid.Parse("1fd63066-b671-4fbf-9017-03e69bad7a79"), }, { Guid.Parse("7b79d1e1-f624-4782-8c75-5d35bda0ac9e"), Guid.Parse("4cbed53b-7a2b-4089-a65a-2692aacb3706"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 91,
    Value = 
new System.Guid[,] { { Guid.Parse("36a5ebdc-c899-45f4-82cf-1e110a2e7e28"), Guid.Parse("c5d97176-131a-4fb5-b425-b2181d42de6b"), }, { Guid.Parse("37f1aa53-59f2-4e9f-aab3-791d28d8db1c"), Guid.Parse("71f305ac-be93-41c6-b1bc-1b5a29ea654e"), }, },
    NullableValue = null,
},
    NullableValue = null,
},
            new GuiduuidMMArrayD2E1M
{
    Id = 157,
    Value = 
new System.Guid[,] { { Guid.Parse("5d62cb4c-57d9-4e44-b29a-da9b490205a5"), Guid.Parse("8e9902e2-19dc-4104-ad87-84af190431bb"), }, { Guid.Parse("83b6c8e1-bda2-4ba7-b9b1-641d8dd36979"), Guid.Parse("41983991-1feb-475d-9d7c-e2355e33e00a"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("059b83f3-cc2a-4d05-b767-dfbdd036e8b7"), Guid.Parse("e81667bb-2321-4c29-9410-65206e44112d"), }, { Guid.Parse("5de04615-b3d3-4470-b2d3-e4b4a5b17f35"), Guid.Parse("1d6fc6ed-bdac-4fae-8027-a7ac87315749"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 165,
    Value = 
new System.Guid[,] { { Guid.Parse("3e283fca-fba2-4970-8f2c-2aa0f01162dc"), Guid.Parse("fd52609e-b4ec-4d4a-9c59-2b73f5e1d51f"), }, { Guid.Parse("212f0b39-6f1d-4aee-89ab-421cabb76075"), Guid.Parse("19f20fbb-eead-426d-aa78-f5d95ca10edb"), }, },
    ModelInner = new GuiduuidMMArrayD2E1MI
{
    Id = 92,
    Value = 
new System.Guid[,] { { Guid.Parse("fed3e6b3-6d3d-4713-b578-63c2f83b60a9"), Guid.Parse("d89d8462-83e8-44e7-96c8-3a98e114dd1f"), }, { Guid.Parse("b2767514-3182-44bb-bde8-5c64b6f8560b"), Guid.Parse("cb41adfe-9fd8-4152-9c39-66a393e2e620"), }, },
    NullableValue = 
new System.Guid[,] { { Guid.Parse("cf522a4d-34be-4064-aec9-7bf3ed9884f9"), Guid.Parse("23eb7fa1-31b7-4bae-9428-eedb83fe7251"), }, { Guid.Parse("6e24e5bd-9ebc-4d28-8276-214f65e6c105"), Guid.Parse("0b0383f0-2556-4539-9db8-5ca2824b531b"), }, },
},
    NullableValue = 
new System.Guid[,] { { Guid.Parse("920a613f-7d45-45f4-881a-c563cd4774c5"), Guid.Parse("8417bc49-6188-4391-8952-87681d234ab7"), }, { Guid.Parse("f92efaca-1f58-45b0-b726-e6ce4d858e44"), Guid.Parse("7f6913ce-b5d3-4bf0-848c-1ee073603464"), }, },
},
            new GuiduuidMMArrayD2E1M
{
    Id = 169,
    Value = 
new System.Guid[,] { { Guid.Parse("ecdcea99-a80f-4af8-a08e-189b220ba724"), Guid.Parse("89844446-7db1-4fc6-8979-383105e7713b"), }, { Guid.Parse("970333b3-5327-4cc8-b987-45758e005f28"), Guid.Parse("72d9a4b4-cd8f-4973-b7b1-e86029c543e5"), }, },
    ModelInner = null,
    NullableValue = 
new System.Guid[,] { { Guid.Parse("6bf16c14-ccb3-4ba8-a4be-664fc3247177"), Guid.Parse("55bc66cd-0639-4667-aff6-de306b0f06d3"), }, { Guid.Parse("639decc2-c31f-410d-8041-3c07a2a5bb72"), Guid.Parse("be2fdaae-22cd-41ca-999a-a77215aab825"), }, },
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("5c846a26-2902-4e12-89b8-fdd9250478c1"), Guid.Parse("7879264d-077b-4ca2-a907-16ebd24b15bd"), }, { Guid.Parse("c69e7c2b-91f1-4349-a5fe-1d044758feb0"), Guid.Parse("e461ac03-964b-4b5e-8996-62052cf88d2d"), }, }));
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
new System.Guid[,] { { Guid.Parse("c42b7fb6-b153-46cc-8074-13a7e4db6b07"), Guid.Parse("8dc00ea2-6a47-4ca2-885d-b8020c0de9e1"), }, { Guid.Parse("f1ae37fb-dc23-4118-9a0f-5ce7d2b203c9"), Guid.Parse("e9627b8b-e597-4a6a-a5df-dae0c2e79acc"), }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("2877f5cd-28b8-4a26-815d-34965cdca5b2"), Guid.Parse("4f2e363c-1ed7-4cb0-97a4-2c008b814457"), }, { Guid.Parse("284ff655-8a6d-4ba8-939d-6e7382b6bd09"), Guid.Parse("882fcc50-e41b-4292-b80b-239ba2f8f9f2"), }, }));
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
new System.Guid[,] { { Guid.Parse("0b085253-c3ae-4b11-836f-05908d23b234"), Guid.Parse("5a9f3fe3-a3d8-4651-869d-66097c1251e3"), }, { Guid.Parse("3f4d8ea7-a022-4922-8168-8f00e6c70770"), Guid.Parse("55ea94f3-4972-4a04-96e0-c9bdf2322f4c"), }, }));
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
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("0d0d4462-16db-42e0-a110-9ea943a2eb3e"), Guid.Parse("ce768e7e-52c7-4194-83a0-0a6198c539e1"), }, { Guid.Parse("4f8bfdf5-d54c-42c8-9e4e-2f2278cc9e91"), Guid.Parse("4d0a4824-a844-4d75-a48c-c22790998bc0"), }, }));
                nullable = await ((IGuidMArrayuuidMMArrayD2)this).ScalarInsertModelReturningAsync(connection, _testData[11].Id, _testData[11].Value, _testData[11].NullableValue, _testData[11].ModelInner == null ? null : _testData[11].ModelInner.Id);
                Assert.That(nullable, Is.Not.Null);
                Assert.That(nullable, Is.EqualTo(
new System.Guid[,] { { Guid.Parse("62071a0b-ccab-4d82-9afd-2168370e9ff3"), Guid.Parse("f910b1e5-8013-407b-8732-76c0dd652ff3"), }, { Guid.Parse("b75e58e3-4499-4a34-898c-68bd65091242"), Guid.Parse("2b7e544f-e7fc-48d5-83fd-10ec3fad1643"), }, }));
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
                parametr1.Value = 21;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                Assert.That(firstItems1, Has.Count.EqualTo(30));
                Assert.That(firstItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[29],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(10));
                Assert.That(secondItems2, Has.Count.EqualTo(10));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTestAsync()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 79;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
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
                parametr1.Value = 30;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 151;
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
                Assert.That(firstItems1, Has.Count.EqualTo(29));
                Assert.That(firstItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[28],_testData[34], false);
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

        [Test, Order(2)]
        public async Task DbConnectionMMDynQuerySelectModelDynParBatchTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                var parametr1 = connection.CreateCommand().CreateParameter();
                parametr1.Value = 12;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 87;
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
                Assert.That(secondItems1, Has.Count.EqualTo(16));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[34], false);
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
                parametr1.Value = 59;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 106;
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
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(13));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[34], false);
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
                parametr1.Value = 74;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 30;
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
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(29));
                Assert.That(secondItems2, Has.Count.EqualTo(29));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[34], false);
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
                parametr1.Value = 132;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 119;
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
                        Assert.That(models, Has.Count.EqualTo(7));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
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
                parametr1.Value = 113;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 47;
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
                Assert.That(firstItems1, Has.Count.EqualTo(12));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(25));
                Assert.That(secondItems2, Has.Count.EqualTo(25));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[34], false);
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
                parametr1.Value = 79;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 113;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatchAsync(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(19));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(12));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[34], false);
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
                parametr1.Value = 87;
                parametr1.DbType = (System.Data.DbType)(11);
                parametr1.ParameterName = "id";

                var parametr2 = connection.CreateCommand().CreateParameter();
                parametr2.Value = 17;
                parametr2.DbType = (System.Data.DbType)(11);
                parametr2.ParameterName = "id";
                int resultIndex = 0;
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelDynParBatch(connection, [parametr1], [parametr2]))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(16));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatchAsync(connection, 34, query1, 21, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(30));
                Assert.That(secondItems2, Has.Count.EqualTo(30));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[21],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[22],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[23],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[24],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[25],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[26],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[27],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[27],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[28],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[28],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[29],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[29],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatchAsync(connection, 153, query1, 39, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
                Assert.That(firstItems1, Has.Count.EqualTo(3));
                Assert.That(firstItems2, Has.Count.EqualTo(3));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTMMDynQuerySelectModelBatch(connection, 74, query1, 79, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(20));
                Assert.That(firstItems2, Has.Count.EqualTo(20));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[0],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[1],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[2],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[3],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[4],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[5],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[6],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[7],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[8],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[9],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[10],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[11],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[12],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[13],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[14],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[15],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[16],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[17],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[18],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems2[19],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionMMDynQuerySelectModelBatch(connection, 85, query1, 36, query2, (item1, item2) => { firstItems1.Add(item1); firstItems2.Add(item2); }, (item1) => { secondItems1.Add(item1); });
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
                Assert.That(secondItems1, Has.Count.EqualTo(27));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[21],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[22],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[23],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[24],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[25],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[26],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatchAsync(connection, 153, query1, 18, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(3));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(31));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[4], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[5], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[6], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[7], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[8], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[9], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[10], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[11], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[34], false);
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
                await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatchAsync(connection, 65, query1, 106, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(22));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[21],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTDynQuerySelectModelBatch(connection, 59, query1, 92, query2))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(23));

                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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
                 ((IGuidMArrayuuidMMArrayD2)this).DbConnectionDynQuerySelectModelBatch(connection, 73, query1, 73, query2, (item1) => { firstItems1.Add(item1); }, (item1, item2) => { secondItems1.Add(item1); secondItems2.Add(item2); });
                Assert.That(firstItems1, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(firstItems1[20],_testData[34], false);
                Assert.That(secondItems1, Has.Count.EqualTo(21));
                Assert.That(secondItems2, Has.Count.EqualTo(21));
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[0],_testData[14], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[1],_testData[15], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[2],_testData[16], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[3],_testData[17], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[4],_testData[18], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[5],_testData[19], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[6],_testData[20], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[7],_testData[21], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[8],_testData[22], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[9],_testData[23], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[10],_testData[24], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[11],_testData[25], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[12],_testData[26], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[13],_testData[27], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[14],_testData[28], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[15],_testData[29], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[16],_testData[30], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[17],_testData[31], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[18],_testData[32], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[19],_testData[33], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems1[20],_testData[34], false);
                        FlatGuiduuidMMArrayD2E1M.AssertModel(secondItems2[20],_testData[34], false);
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
                foreach(var batchResult in await ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatchAsync(connection, 65, 12))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(22));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(33));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[2], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[3], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[4], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[5], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[6], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[7], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[8], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[9], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[10], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[11], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[12], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[13], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[14], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[15], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[16], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[23],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[24],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[25],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[26],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[27],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[28],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[29],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[30],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[31],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[32],_testData[34], false);
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
                foreach(var batchResult in  ((IGuidMArrayuuidMMArrayD2)this).DbConnectionSTSelectModelBatch(connection, 81, 119))
                {
                    if(++resultIndex == 1)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(18));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[17], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[18], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[19], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[20], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[21], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[22], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[23], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[24], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[34], false);
                        continue;
                    }                    

                    if(resultIndex == 2)
                    {
                        var models = batchResult;
                        Assert.That(models, Has.Count.EqualTo(10));

                        GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[25], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[26], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[27], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[28], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[29], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[30], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[31], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[32], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[33], false);
                        GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[34], false);
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
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 74);
                var models = await ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommandAsync(cmd);

                Assert.That(models, Has.Count.EqualTo(20));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[15], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[16], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[17], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[18], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[34], false);
            }
        }

        [Test, Order(2)]
        public async Task DbConnectionCommandSelectModelTest()
        {
            await using (var connection = GlobalSetUp.GetDbConnection)
            {
                await connection.OpenAsync();
                 using var cmd =  ((IGuidMArrayuuidMMArrayD2)this).CreateDbConnectionSelectModelCommand(connection);
                ((IGuidMArrayuuidMMArrayD2)this).SetDbConnectionSelectModelParametrs(cmd, 59);
                var models =  ((IGuidMArrayuuidMMArrayD2)this).ExecuteDbConnectionSelectModelCommand(cmd);

                Assert.That(models, Has.Count.EqualTo(23));

                GuiduuidMMArrayD2E1M.AssertModel(models[0],_testData[12], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[1],_testData[13], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[2],_testData[14], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[3],_testData[15], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[4],_testData[16], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[5],_testData[17], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[6],_testData[18], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[7],_testData[19], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[8],_testData[20], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[9],_testData[21], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[10],_testData[22], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[11],_testData[23], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[12],_testData[24], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[13],_testData[25], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[14],_testData[26], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[15],_testData[27], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[16],_testData[28], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[17],_testData[29], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[18],_testData[30], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[19],_testData[31], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[20],_testData[32], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[21],_testData[33], false);
                GuiduuidMMArrayD2E1M.AssertModel(models[22],_testData[34], false);
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

