

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
    internal partial interface IGuidMArrayMArrayD1
    {
    }
    
    internal partial class GuidMArrayMArrayD1 : IGuidMArrayMArrayD1
    {


#region TestData

        private readonly GuidMArrayD1E1M[] _testData = new GuidMArrayD1E1M[]
        {
            new GuidMArrayD1E1M
{
    Id = 9,
    Value = 
new System.Guid[3]
{
Guid.Parse("335c03ad-dff9-4578-ae1c-6b5bbd2d0f26"),
Guid.Parse("5628b812-a578-48ad-937a-460b2bf3e950"),
Guid.Parse("b57d77bf-7ac9-4513-9a3b-82679dd08aac"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 6,
    Value = 
new System.Guid[4]
{
Guid.Parse("444f5cb0-92c0-48c4-aab9-6a31fc943626"),
Guid.Parse("930a6745-b234-46b2-a44b-7b8697358fcc"),
Guid.Parse("fd97bae1-59ce-4147-9455-e909e7d97390"),
Guid.Parse("a489cff8-ddaa-4746-ab50-6c811715ea2e"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f5c33d5d-1540-4efb-80ff-155a826872e7"),
Guid.Parse("0e6fc1f3-8f4a-4148-925c-411ff0780921"),
Guid.Parse("85ea9364-2ff2-42ea-b78e-049eb7f17aab"),
Guid.Parse("20c2fc93-73aa-481b-a6dc-6a5a2a786bf7"),
},
},
            new GuidMArrayD1E1M
{
    Id = 16,
    Value = 
new System.Guid[3]
{
Guid.Parse("726ba519-ad7f-45c9-b12a-af35d9a26f69"),
Guid.Parse("e46d68e7-2cce-4848-8877-9529fb77a4d8"),
Guid.Parse("2a7ccf79-6e78-4f28-8598-3bf71d9fd28a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 15,
    Value = 
new System.Guid[4]
{
Guid.Parse("bc23bbdf-7bef-4ed4-8d31-039899e66d35"),
Guid.Parse("383f550d-fc6d-42c5-b536-0fce249aed1b"),
Guid.Parse("4fc6ba17-88cd-4ded-bb5c-ed712b7d68d8"),
Guid.Parse("ec6b43cf-8941-4c51-a4f5-73074cf7b5ac"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f081d416-6e35-40a5-aa2b-77f092ba2dbe"),
Guid.Parse("a83d9d49-b7e8-4bfe-97c3-836c6bf05985"),
Guid.Parse("0578ee06-a7a3-4d29-bee5-fa60a7c03967"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("84125075-be4b-44c1-b71a-5722b731e3bd"),
Guid.Parse("83c49a26-4fb9-49d8-823a-09218a0e5d59"),
Guid.Parse("a68cf937-b919-4575-a89d-f3ea4c18f302"),
},
},
            new GuidMArrayD1E1M
{
    Id = 25,
    Value = 
new System.Guid[3]
{
Guid.Parse("417660f5-431f-46b6-95d3-1c0efad6e225"),
Guid.Parse("8deef3ce-753c-475a-b31d-93e38dbec77f"),
Guid.Parse("4edb7a17-5ffe-4e1b-998d-4be03c61e957"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 24,
    Value = 
new System.Guid[4]
{
Guid.Parse("61576dc5-70b0-47b7-b5a6-c83b383de27f"),
Guid.Parse("1cb084a0-fb0f-4a53-b44a-db9a30513e72"),
Guid.Parse("12de2bdc-4160-408b-82b9-767c2c44a3e4"),
Guid.Parse("d90effe0-f52e-4673-844c-894237b30909"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d15362c1-1cfc-493f-8c47-0507b1d5adae"),
Guid.Parse("fa47fc93-e456-40ff-b513-28b317ada488"),
Guid.Parse("accf0097-b71e-48aa-bf4f-acb37347f1f9"),
Guid.Parse("53378462-b59f-401f-983e-221afc7edcef"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 31,
    Value = 
new System.Guid[4]
{
Guid.Parse("133cbf06-b519-4634-a88b-b901dd90e698"),
Guid.Parse("d63b865f-5146-49c1-832b-22d5b7cae3ad"),
Guid.Parse("098ae595-e533-404b-b53f-979057df810a"),
Guid.Parse("6b054659-4243-465b-81c6-08cefac12bb0"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 32,
    Value = 
new System.Guid[3]
{
Guid.Parse("9f47dcae-5acf-4a42-809e-cb0d4ec1eb21"),
Guid.Parse("8255c147-42ee-4956-bb0d-0c4a77cf3527"),
Guid.Parse("27dac8de-3d1d-435e-8595-3a1a42a81820"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("214c2a74-b6ee-4857-911a-b5c226d62f74"),
Guid.Parse("3f955c62-26a5-4aca-bf45-8088937dd135"),
Guid.Parse("aa916a92-c600-4db4-a964-141eb1970be8"),
Guid.Parse("f27e98ac-b745-4483-babf-820afbfa815a"),
},
},
            new GuidMArrayD1E1M
{
    Id = 40,
    Value = 
new System.Guid[3]
{
Guid.Parse("4f530c0b-35ae-473c-8be3-58296a596bbd"),
Guid.Parse("8ae5ada3-986a-4937-b91e-ebb6947d853b"),
Guid.Parse("5f9b7033-5682-4720-b783-f845ce29a2d9"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 33,
    Value = 
new System.Guid[4]
{
Guid.Parse("28e509e3-7e31-4706-8153-e4b522a34df3"),
Guid.Parse("44a673f5-3cd2-4e5e-95d1-38896769ceac"),
Guid.Parse("31a5a6e1-cf22-411a-9939-f2f726486f78"),
Guid.Parse("1cde3815-4339-4dcf-b39e-d7708bdbbfda"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5df8940a-d292-42ae-839c-6af0a65391f3"),
Guid.Parse("723bd1c2-b259-4e57-940e-a4e8ee716275"),
Guid.Parse("cf3b91bd-db19-40b0-9296-50ca243a4008"),
},
},
            new GuidMArrayD1E1M
{
    Id = 45,
    Value = 
new System.Guid[4]
{
Guid.Parse("9e973b9a-44f9-4a02-aeb0-c7b609124759"),
Guid.Parse("a6e8cbc3-8772-44b8-b425-1bec1fc37586"),
Guid.Parse("fbf9b3f8-09ff-474b-b581-88605c88930b"),
Guid.Parse("a751a200-a924-4d5d-b39a-d912543fa29f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 37,
    Value = 
new System.Guid[4]
{
Guid.Parse("79a4998a-f448-42fa-9451-f0218f6fc40d"),
Guid.Parse("41b23a37-56d0-466f-927a-d7cdaa024ad9"),
Guid.Parse("7036224b-48d7-4553-84fc-18a9ee5246c7"),
Guid.Parse("b48e8cde-afe6-48e0-a262-5f138646e927"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7bb9548a-25e1-45bb-848f-4ffd24fd9511"),
Guid.Parse("e2a7168c-7c40-444c-8391-edca4ede4c42"),
Guid.Parse("1796ff5e-ad57-4f32-8225-3fe9dcb08e9a"),
Guid.Parse("e983c6a9-7de2-4a47-a8b6-1836547eec95"),
},
},
            new GuidMArrayD1E1M
{
    Id = 54,
    Value = 
new System.Guid[3]
{
Guid.Parse("cb78a6e6-366e-4ddd-904b-ee92c6ea086b"),
Guid.Parse("712c9faa-6b4d-4c25-ab3c-7a1e08178475"),
Guid.Parse("0e22af75-2616-4ed7-b78f-e80dad363e76"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 46,
    Value = 
new System.Guid[4]
{
Guid.Parse("60e3a554-a5d6-4466-95d4-e335af370154"),
Guid.Parse("ad7fa35b-4d2c-4f03-b0d3-af73c6a1d7f6"),
Guid.Parse("92bdb7fd-3808-4a6c-a266-80e937ac0ccf"),
Guid.Parse("5e164c2e-8abf-4c60-9922-991a891541f4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("25476d6d-da65-4764-a320-1632d961cc20"),
Guid.Parse("545f2039-22ae-46b2-b93b-e5ccc444d7b9"),
Guid.Parse("759c32ff-5aae-4925-a867-b4c579936d97"),
Guid.Parse("740c71ad-80ad-46bf-b89b-0cc735a2aa75"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 55,
    Value = 
new System.Guid[3]
{
Guid.Parse("6a1747ab-5a51-46b7-b8b5-2111f92734ac"),
Guid.Parse("ef557878-52b8-4371-8f62-ad3c5423a424"),
Guid.Parse("46a351c4-e8ca-44fc-892c-988ad2a21cf6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 47,
    Value = 
new System.Guid[3]
{
Guid.Parse("bb931cdc-3934-45ac-a066-00ba492ac688"),
Guid.Parse("e89c53d7-4ae2-46c9-987e-666ceddd07fe"),
Guid.Parse("293727dd-4321-4796-84e8-747f743ee494"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("7f85e91b-b0a0-4482-989f-b66c3b7ae15a"),
Guid.Parse("94b2a09e-4668-4e6e-be7f-39e4553f7787"),
Guid.Parse("fd1fdfaf-c81f-47e4-8b82-efc39f713650"),
Guid.Parse("64e026c0-3ed9-41ad-8627-8feece7626ed"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("ddbd376d-c41b-45f7-afbc-098c4015faf4"),
Guid.Parse("aec6642f-7c43-4f59-82fa-9fab087ffabb"),
Guid.Parse("2400889b-70ce-40c7-ab17-5868a7c0ef64"),
},
},
            new GuidMArrayD1E1M
{
    Id = 58,
    Value = 
new System.Guid[4]
{
Guid.Parse("46fcaca4-4b0b-4353-b0fd-69952ea45f84"),
Guid.Parse("e0977768-bee1-46be-b531-4e486099dc67"),
Guid.Parse("32d1ac88-fc57-4a5d-8a6e-bf462f777b45"),
Guid.Parse("413edde0-f344-40cb-a4f8-8ca8eb4b435d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 49,
    Value = 
new System.Guid[3]
{
Guid.Parse("cbe07d7a-9ea0-43b0-b62b-be51e86529ee"),
Guid.Parse("d18c7f54-e6af-461b-948a-fef0f8768afe"),
Guid.Parse("9ba231c8-25e6-4c3c-a7dc-12d36c65973b"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("1e9a56bc-2c86-4b55-a9ce-ad43afc4d659"),
Guid.Parse("db411253-4aa1-4e0c-852f-0c1a49f8b592"),
Guid.Parse("6acc00b1-505d-4926-a757-8411ee99decd"),
Guid.Parse("604c294a-1b68-4c2c-9d64-3287a9361f93"),
},
},
            new GuidMArrayD1E1M
{
    Id = 60,
    Value = 
new System.Guid[4]
{
Guid.Parse("6322c7d6-a3ef-4b79-8c52-2010bfd24641"),
Guid.Parse("a1cf81e6-ca7f-4ad3-87c0-1ecbee4e548a"),
Guid.Parse("957bd27a-9ab9-47ef-9319-0a9f97827751"),
Guid.Parse("e4bba754-fe73-44be-9e59-e5549a96372e"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 53,
    Value = 
new System.Guid[3]
{
Guid.Parse("0af7736e-95e8-40e0-9b68-aac4d385996c"),
Guid.Parse("19bde709-16dd-46a8-891d-20d7337a1a41"),
Guid.Parse("dbe0a3be-cb79-47b4-a9ea-70e13d44716c"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 65,
    Value = 
new System.Guid[4]
{
Guid.Parse("ad39b65b-e733-4915-afec-8f58768f4d26"),
Guid.Parse("4968c25c-d264-4b7a-93e0-3f9098370c4e"),
Guid.Parse("8fd99159-4027-4bcb-8c6d-a230f1f00224"),
Guid.Parse("c3137ea0-336c-43de-a05e-1d7a8fa7c246"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 55,
    Value = 
new System.Guid[4]
{
Guid.Parse("63e2cc0b-54b1-4037-8f34-368b12d99458"),
Guid.Parse("2ef6b5b5-3497-419a-9bdf-0e0683a1e1d1"),
Guid.Parse("c1dda441-294c-469f-af7d-2d8bd1a2973d"),
Guid.Parse("62e81e96-62d3-4a02-b678-daf352dbdc5d"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("cae86044-c50f-4e24-8c25-08548f4c88bf"),
Guid.Parse("a1fc6fe8-7aef-4fe6-80a2-d246664318b1"),
Guid.Parse("6530e226-c58b-4f0c-a0f6-cb748da2040b"),
Guid.Parse("7bf115c1-8dc1-42d7-81d8-d3fd9dfc3404"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 74,
    Value = 
new System.Guid[4]
{
Guid.Parse("c40d5c14-bc6b-43c7-8d52-fff499519935"),
Guid.Parse("9db0a553-dc49-4fcd-adb5-ab98e2d30e8d"),
Guid.Parse("7b9667ac-32e5-44ef-8ab2-bd4f0ab345c0"),
Guid.Parse("b8c825c1-6241-486e-b542-b38e9b76d4e3"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 61,
    Value = 
new System.Guid[4]
{
Guid.Parse("5dece2d4-9342-48d8-a0c1-80e937fe7ade"),
Guid.Parse("14ec5490-a435-427b-82d6-52b367aac04a"),
Guid.Parse("bbf159f6-1ff0-4434-8482-d5692d17ee0d"),
Guid.Parse("7cf5322f-0892-4216-991d-686ee909b4eb"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("3feb98be-995d-4178-acaf-3a67bc8b90a2"),
Guid.Parse("c0d695cb-d07f-46ee-a923-d3cfbf956620"),
Guid.Parse("04742a1b-1450-4c54-853e-27fa6323e277"),
Guid.Parse("14e2385e-64ca-402b-93de-48842017213e"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 76,
    Value = 
new System.Guid[4]
{
Guid.Parse("6b883920-70d7-48d1-b7b5-bf12f1f71a47"),
Guid.Parse("d095f6ee-03da-492c-9a8a-93ed033a2dda"),
Guid.Parse("2e514020-9088-494e-89d5-d0743475b958"),
Guid.Parse("38c80cb7-b11a-4873-a4ee-d52e4f3587f2"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 70,
    Value = 
new System.Guid[3]
{
Guid.Parse("cb8820e7-5fa7-447b-92ce-4f404333fa28"),
Guid.Parse("ba1a8952-8633-4696-874a-eb6aa41a6758"),
Guid.Parse("5576cb37-ec7d-4df9-a3bc-55fa4776b3c5"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("96bf87c6-1fbb-4d2d-8bcf-3651e3254370"),
Guid.Parse("f2317e72-f784-4854-a918-283c406ea5bc"),
Guid.Parse("a1f61753-10c3-454b-a15d-9fc1e5ffba91"),
Guid.Parse("230ec653-b303-492e-8760-4eb5d707a942"),
},
},
            new GuidMArrayD1E1M
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("85acdb0c-fed1-4f03-98cd-dc817e25d0d6"),
Guid.Parse("78c2e795-5fb6-4391-a343-3e9a992a153f"),
Guid.Parse("d658879d-5d13-4547-be4d-2e51fb97ee47"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 72,
    Value = 
new System.Guid[3]
{
Guid.Parse("6d75fda7-4637-4ad7-a8bc-659edc949115"),
Guid.Parse("86beddf5-79af-4929-b943-4da09deb198a"),
Guid.Parse("752db9da-d0fb-4ea4-8150-5168c54115ad"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("f4475f00-f2e6-4ef3-8e92-e278631e0827"),
Guid.Parse("761a1430-378f-4ba7-a023-5db390510d39"),
Guid.Parse("0470a413-1c9f-4fae-b4b0-bcbe992428de"),
Guid.Parse("68d8f366-ee79-4182-bb67-0a20f0fb4c81"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("f6645748-ca24-4987-ac33-bc2c24cdac84"),
Guid.Parse("21a7e98a-ca12-422f-bc71-171a3adac08e"),
Guid.Parse("8e392777-b3e6-48d2-b369-6888ea37720e"),
},
},
            new GuidMArrayD1E1M
{
    Id = 85,
    Value = 
new System.Guid[3]
{
Guid.Parse("ae16f840-6744-4201-a713-7737b31227d8"),
Guid.Parse("330e0ae7-1bee-4c9b-ba25-7ff587daebaa"),
Guid.Parse("159c91a5-535e-4220-9271-c57a5aa2bf2d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 78,
    Value = 
new System.Guid[4]
{
Guid.Parse("be09f584-e2e6-4269-a588-6b45f5965bb5"),
Guid.Parse("1212d058-5c43-4f99-a074-cd02a6cc3853"),
Guid.Parse("69e56b2b-a548-4895-b21e-956774515304"),
Guid.Parse("7bbf9de5-330b-4d0f-ba59-4dc7cd9bd9f7"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("506f9872-9208-425f-a2b9-39c226100874"),
Guid.Parse("16211545-95d5-473f-b2dd-20f5c0f4c65b"),
Guid.Parse("72f397b0-8554-43a8-b0b6-89f3cd68e4a3"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 92,
    Value = 
new System.Guid[3]
{
Guid.Parse("6fe59a58-2db2-4d25-8db0-9f86b561df4d"),
Guid.Parse("75bafe37-22c6-433c-a845-5c73c53238b9"),
Guid.Parse("0013b0b0-9555-4804-8dbe-b9c5a01f5c8d"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 79,
    Value = 
new System.Guid[3]
{
Guid.Parse("3b1d2052-7826-4a49-95dd-df55da9a6b19"),
Guid.Parse("cbaf8e9b-06f0-4889-a500-3b18440bb564"),
Guid.Parse("5a6521fb-2bb6-423e-8533-78924bd9b8e0"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("537e616c-528d-4ef8-b883-b28a7da62523"),
Guid.Parse("7fe41a80-2237-42dc-8956-5890f9ecbdee"),
Guid.Parse("3f7d52c1-2639-4c22-b7da-14dc2c0983f1"),
Guid.Parse("30e15b6d-75b8-4d76-af7d-c3fbeac8fe7f"),
},
},
            new GuidMArrayD1E1M
{
    Id = 96,
    Value = 
new System.Guid[3]
{
Guid.Parse("b3fd88fc-7c44-4caf-8ca1-9e84bb4c5e0b"),
Guid.Parse("a80f3782-e4f1-494b-a20a-df56c663ae6a"),
Guid.Parse("0e2d154c-4af3-4ec0-bad3-ed3d2d5a6bbb"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 80,
    Value = 
new System.Guid[3]
{
Guid.Parse("62d20639-6b9c-495f-8ed0-74f50bc42eb0"),
Guid.Parse("f06616f7-6648-42e5-8830-696a1c5f9507"),
Guid.Parse("a1b6d151-fa9a-4ead-839d-781751a1418e"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 103,
    Value = 
new System.Guid[4]
{
Guid.Parse("1834054c-768f-48f3-9217-fe26c598bc59"),
Guid.Parse("aa337ab7-f73d-4d2e-85a3-16a2e25ef3c6"),
Guid.Parse("3194bdee-3183-4424-a8e9-b54da8757d58"),
Guid.Parse("4b40cc71-efdf-47d6-8aa8-8bdb27b0dbd4"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 82,
    Value = 
new System.Guid[3]
{
Guid.Parse("f1b58bd4-5575-4524-a2ff-89b43262be40"),
Guid.Parse("13c5e647-4c3e-4aaa-88d8-5667ea7c4919"),
Guid.Parse("d272d8ef-1bf9-4086-92b0-ed01463b302e"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("894c58a5-56f4-44d4-8b7c-864122530fe1"),
Guid.Parse("7c98bac0-dfc0-447f-b66a-4dbbf3519c3f"),
Guid.Parse("4c8b5283-7d93-4319-b84a-22d63d6f387f"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 83,
    Value = 
new System.Guid[3]
{
Guid.Parse("122fa5d4-5de0-4b32-ad9a-7ca057a38479"),
Guid.Parse("ebd52b7d-874b-4b65-ae54-7e7261a5c908"),
Guid.Parse("d2db1aeb-85cf-4eac-9d98-a165fad80e3c"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("88e2a1fa-251a-4b4e-9a0b-a5a448e5dbf6"),
Guid.Parse("a4bc975d-2bbf-4be8-ad5b-e2d017b009d7"),
Guid.Parse("7c809919-78cf-4b02-82a4-768f39ffb328"),
Guid.Parse("a20b62ef-dfb4-4314-822c-65ade8b14590"),
},
},
            new GuidMArrayD1E1M
{
    Id = 116,
    Value = 
new System.Guid[4]
{
Guid.Parse("11af3b79-ece2-4c3a-9f29-e128fb79f2e4"),
Guid.Parse("ea5d7e2f-006a-4047-8313-395f3b2961cb"),
Guid.Parse("cc629fe5-64a3-4f13-be8b-20afa3b071ed"),
Guid.Parse("ed0344f2-6e27-4061-bacd-225fd6a82e72"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 86,
    Value = 
new System.Guid[4]
{
Guid.Parse("8bf583e7-deca-4868-86d7-ec5767911678"),
Guid.Parse("a24571f7-b103-47fe-b33c-566f71549776"),
Guid.Parse("ce377c69-0770-4ada-b83a-ea13fbb698f1"),
Guid.Parse("75770765-6b55-4df5-8f8d-ce6fb3443ab4"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("29ca7787-7061-477a-a6e8-fa3e89be73b0"),
Guid.Parse("c4db0189-a3a5-4fec-8e40-a3012a413a74"),
Guid.Parse("951c645d-2734-40d8-8c6b-29f516c4eef3"),
Guid.Parse("07a35e4a-2d44-4cbb-9e06-a11d809007c7"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 122,
    Value = 
new System.Guid[4]
{
Guid.Parse("303168fe-b487-478f-8587-c8567a4e0136"),
Guid.Parse("d16a2a9c-bfa7-4241-9931-5b2c64f1dd96"),
Guid.Parse("0f34651e-c1e2-416b-939a-6ecb136fcbec"),
Guid.Parse("89693af4-8910-4dc3-9b76-b71065e685f6"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 95,
    Value = 
new System.Guid[4]
{
Guid.Parse("3241fd34-385a-40fd-98aa-444ae757b901"),
Guid.Parse("db28e903-486a-4c2c-a59e-7eae15fd9ed6"),
Guid.Parse("776baf18-3665-4765-8334-c2cd301a8c47"),
Guid.Parse("061f1a23-169f-4609-9780-1981dff7abf1"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("151d4e8d-5f2f-4e1e-9a42-39a4b7976afd"),
Guid.Parse("15712f4c-0867-4d20-a1c7-bed05f78fbc3"),
Guid.Parse("ee9d03b8-9d58-4656-8f41-c26d20af18bc"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 129,
    Value = 
new System.Guid[3]
{
Guid.Parse("ac7431e9-aaab-4306-adbd-bf3107a064fa"),
Guid.Parse("45705437-4936-4f09-af02-97f7e2634c43"),
Guid.Parse("2e87fb3c-abf2-47d2-ab7e-0010f40e6621"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 102,
    Value = 
new System.Guid[3]
{
Guid.Parse("3858309b-49ba-4bc4-a677-822aead5a7eb"),
Guid.Parse("fb5652a8-5b25-409b-96d8-13416bad4f07"),
Guid.Parse("701f52d7-d1c8-432a-8745-0db783b556de"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 136,
    Value = 
new System.Guid[3]
{
Guid.Parse("9b2dd294-ace1-4b1b-af71-aa5eb7a6401d"),
Guid.Parse("fe9686e4-60ec-4809-8fdc-eaabd2637bfb"),
Guid.Parse("3d3832b8-ef10-4047-b6e8-2285236f0357"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 111,
    Value = 
new System.Guid[3]
{
Guid.Parse("190ec104-348f-43c2-8075-c9d645f5720d"),
Guid.Parse("471513e4-f925-479c-a67c-ed1a8b83fecd"),
Guid.Parse("6c59fddd-779b-478f-93f4-f5c9db469f88"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("b68cda07-828a-4bdc-aa4e-43346f6d859b"),
Guid.Parse("b3ffe5ea-9b2e-475c-94e4-f449f3617a6a"),
Guid.Parse("c61e0dec-08bb-4142-a6e9-33f929b98f79"),
Guid.Parse("508d7ad2-34a3-45c6-903c-3327717a7ff0"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("820dfed7-baef-4ba1-afb5-1e0e8b4b5041"),
Guid.Parse("f5e606cb-3812-4bac-80de-f8d6f6b24597"),
Guid.Parse("c159a538-4958-4897-a22d-15ca99798efb"),
},
},
            new GuidMArrayD1E1M
{
    Id = 141,
    Value = 
new System.Guid[4]
{
Guid.Parse("49f4a908-0f58-40c6-8add-e112cbe54848"),
Guid.Parse("a5cb07b0-f8b9-4ddb-92c2-cffc8f2e492b"),
Guid.Parse("d9e7e3f8-a153-483a-bd20-ac111a43aaca"),
Guid.Parse("01443d04-7cbd-42eb-bbec-d31779acd478"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 120,
    Value = 
new System.Guid[4]
{
Guid.Parse("26e30a1a-00fa-44b2-b9ae-95cc5893672f"),
Guid.Parse("c1be0673-ef0c-46cb-81de-143c0172a62d"),
Guid.Parse("feecca05-49bf-4543-ae3a-aeb49193bcde"),
Guid.Parse("1eec2511-d326-4f60-bdb4-f96bbe2b8cd8"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("5b537973-e899-4ed3-9788-4fa9a53bd4ca"),
Guid.Parse("fd1f06f2-e6b8-46e3-9805-4b0a79a31711"),
Guid.Parse("e7837a57-f573-4fcf-ad38-007b21aabcf1"),
},
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("52dde778-1480-4414-a8ec-c2661a52dd1e"),
Guid.Parse("e230e0b9-7224-4772-b5bf-cf6328c24188"),
Guid.Parse("0c54d276-c6fa-4baa-8fe9-80bee1dc7212"),
},
},
            new GuidMArrayD1E1M
{
    Id = 147,
    Value = 
new System.Guid[4]
{
Guid.Parse("9b7d2ff2-ef40-4f88-8a88-da65816e3791"),
Guid.Parse("eeb8716e-5498-443a-bd31-6e7971eb0363"),
Guid.Parse("c3cf571a-34e4-4420-8297-1b32b97be96f"),
Guid.Parse("f28647af-7dd4-4972-9a91-59ff043ea678"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 126,
    Value = 
new System.Guid[3]
{
Guid.Parse("6359cf62-21cb-4754-abfb-622e8a5aaf43"),
Guid.Parse("8d77d554-a9a1-4805-abcd-77870271d83c"),
Guid.Parse("26ce2a94-095c-446b-b82f-5cfe8d50ead4"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 148,
    Value = 
new System.Guid[3]
{
Guid.Parse("2bfb0f6b-2825-47ac-8625-27894ad7f593"),
Guid.Parse("d2f77d05-6db2-47f1-a009-061e679444cd"),
Guid.Parse("34343f71-b9b6-47d1-9af8-f68e4c00f605"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 129,
    Value = 
new System.Guid[4]
{
Guid.Parse("e47268e8-caa8-4d0e-a17b-65c30c0121f6"),
Guid.Parse("f9612d48-545f-448f-9b05-0bed17ccd100"),
Guid.Parse("a2a8c68d-7084-43e8-8608-70112a0f39df"),
Guid.Parse("16811a55-703d-4c23-92d9-1f300b5b2356"),
},
    NullableValue = null,
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("01169180-c8f6-4f78-82ea-2827670fb25f"),
Guid.Parse("58ff8af7-7781-4690-9886-1428529d1484"),
Guid.Parse("f6be9b18-f73f-4256-83e9-07b624e501c2"),
Guid.Parse("51c064e1-1a38-4729-b933-8a709dfffbb1"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 137,
    Value = 
new System.Guid[4]
{
Guid.Parse("f8510230-2e1a-4afd-bdac-10b5af1eeeda"),
Guid.Parse("8e9460c7-7dd2-4b86-b299-ea98f39b0b54"),
Guid.Parse("087a5fba-82eb-4e3e-a285-639edf89f6f8"),
Guid.Parse("274f4d3e-c349-4c1f-bb22-8e33208e7764"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("dec22f43-2623-4414-8a72-8b3eed82b007"),
Guid.Parse("7b842766-72fe-4af8-8c27-e78ec3c81627"),
Guid.Parse("1e2e312e-b6c6-4236-904d-8ab1a6ee5c2f"),
},
},
            new GuidMArrayD1E1M
{
    Id = 160,
    Value = 
new System.Guid[4]
{
Guid.Parse("cfcb930a-8dad-4e6c-aabd-03bb6dd81642"),
Guid.Parse("97f560ea-44f1-41a8-9d16-a45600b061fe"),
Guid.Parse("7051c8d9-4e93-48c2-87c1-75b4067b529b"),
Guid.Parse("e1821f9b-fc9a-46f2-910d-813f82b8436a"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 144,
    Value = 
new System.Guid[4]
{
Guid.Parse("11a3827d-25ad-4a7e-9798-3e77c496b37d"),
Guid.Parse("46c513ec-ce3b-4ef4-bb4e-7b7fdcdf0e6e"),
Guid.Parse("0ff03d67-f27b-42b1-ae8f-bb4d37185380"),
Guid.Parse("70b826b3-7ed0-42b9-9577-5f9ddc7e1d2e"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("e11f783b-633d-4eaa-ac0c-3b730529b827"),
Guid.Parse("870ed7ac-8822-41b3-a976-2f913d523cf5"),
Guid.Parse("118945dc-c0b6-4c0f-9a6a-7d81322989f6"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 163,
    Value = 
new System.Guid[4]
{
Guid.Parse("7d2fe177-d0d8-4068-9888-101981851ec2"),
Guid.Parse("3b273571-28cf-45f9-837b-70aef16f74d9"),
Guid.Parse("e34c194b-6c25-4bbd-a731-2b82bcb4decc"),
Guid.Parse("9dc6a1ac-23ca-4498-afc0-a96ddff92530"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 150,
    Value = 
new System.Guid[3]
{
Guid.Parse("80fcb376-5cdf-45fd-bd3f-4a490ef6a848"),
Guid.Parse("1c0fd0d1-9266-4d0d-ba5c-8c6d55585315"),
Guid.Parse("e18d5f63-a61b-42f7-8188-19593f2d088b"),
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("05902b4e-7e3d-4aee-925a-39160610aea9"),
Guid.Parse("599d99b4-21d9-4422-92d5-9defcd90763f"),
Guid.Parse("5ff58060-f97a-4eea-b4fd-f4125ab05f66"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 171,
    Value = 
new System.Guid[3]
{
Guid.Parse("5e1f3030-bf8e-40bc-91b0-eeb03ad7b0ff"),
Guid.Parse("220a705a-a033-4f0e-9a62-4ff231c7a08e"),
Guid.Parse("46d3e446-891b-4156-a84c-a91ce45db815"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 154,
    Value = 
new System.Guid[4]
{
Guid.Parse("61a4a111-1794-490a-a534-4215f4004d09"),
Guid.Parse("344a04e6-a105-4392-9cb5-32419c42d7e3"),
Guid.Parse("3eb62ebd-2d2f-4b49-9c6f-f4ea6f9e3256"),
Guid.Parse("7a575e62-e1e1-4bf8-9873-18c86559b372"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("6a5ef509-8750-437d-9bc5-67dd7e7b504c"),
Guid.Parse("a585a93b-a869-488c-8678-e00b05d65c67"),
Guid.Parse("76f79fda-d916-42fe-8d98-ee5ea3f245f2"),
Guid.Parse("649188ea-e715-4b64-b363-6167c122fee0"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 172,
    Value = 
new System.Guid[3]
{
Guid.Parse("e20008e9-2a5f-4412-b525-7c7c31c13e82"),
Guid.Parse("14611e0b-418f-4fc5-af74-6bd3aaee8be6"),
Guid.Parse("4336293f-6d65-4a36-a8af-43cf5041b479"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 156,
    Value = 
new System.Guid[4]
{
Guid.Parse("bc09120b-6db4-46ef-87e7-e72c2cae1fd3"),
Guid.Parse("b2494ed1-3813-4919-ac44-3e28345c1cd2"),
Guid.Parse("71846348-1c73-4797-962c-72cce51ded3b"),
Guid.Parse("298ea72c-5926-4b0a-8300-2b95ce31321f"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("d7645c9c-f0b8-4b1f-a5f6-21b243a5eda2"),
Guid.Parse("cc2765d3-0706-46d5-8cdc-dc1e8fd42033"),
Guid.Parse("b9d53c1a-34cd-49d0-a039-faeb79143d83"),
Guid.Parse("0f3cc9ba-4691-4291-a09a-74ffae92c28b"),
},
},
            new GuidMArrayD1E1M
{
    Id = 173,
    Value = 
new System.Guid[3]
{
Guid.Parse("e9061b6a-2c22-4373-a194-58d086861d66"),
Guid.Parse("74c417db-2933-4ca0-a84e-188dfd0c7344"),
Guid.Parse("8bdb9bec-e2fa-41da-ab82-f08d38639695"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 161,
    Value = 
new System.Guid[3]
{
Guid.Parse("e2440a41-815a-4693-b33b-04d964a5f2aa"),
Guid.Parse("8e22d6e4-cce1-4f70-9434-590eca075ca4"),
Guid.Parse("58dd8e4e-43ff-4f31-9b65-72f7bd4d2ca2"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("978cd951-96bb-4b23-8f21-610eae7d3faa"),
Guid.Parse("811494b4-1ba8-41ca-977d-eb98d300a0ca"),
Guid.Parse("d70d9573-4ac3-46d4-8866-ba3ed292abb9"),
Guid.Parse("7273ba39-2051-4b55-a6c1-bd425dbda4bf"),
},
},
            new GuidMArrayD1E1M
{
    Id = 177,
    Value = 
new System.Guid[4]
{
Guid.Parse("6e036955-891e-4ab8-bcae-b18a01e8f6f1"),
Guid.Parse("b9ca4fea-628c-4ede-8b0f-2d51702b76aa"),
Guid.Parse("459b1a78-b218-41fc-a296-1135eaa49785"),
Guid.Parse("b5cb7dae-d93e-46ca-97fb-9c859f2ef78c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 163,
    Value = 
new System.Guid[3]
{
Guid.Parse("f9ae57cf-710f-4186-90aa-c7eb52e293d4"),
Guid.Parse("ad2a1f5c-a1e3-49f8-a98e-eecca343e243"),
Guid.Parse("6be7c224-f071-49f9-8dc4-6acab3170d95"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("2253b17e-b59e-4a71-9ec8-756fe7d9029e"),
Guid.Parse("34b2c19d-30a7-40f9-af0e-895d6c9e55ab"),
Guid.Parse("97a9ed41-5b95-4dfe-8c5d-36a985151d48"),
},
},
            new GuidMArrayD1E1M
{
    Id = 185,
    Value = 
new System.Guid[3]
{
Guid.Parse("c06c722c-acc3-4782-8f2b-573c57a09c50"),
Guid.Parse("d42f1247-ee8a-4c9a-8c39-bd3f13f34afe"),
Guid.Parse("8574a430-5be5-4809-bbc7-e005b9a56b5c"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 166,
    Value = 
new System.Guid[4]
{
Guid.Parse("bc8ff1b6-1a54-42e6-a55c-426cfab2ddf8"),
Guid.Parse("6b4879d8-e429-4bd8-b984-69f78acff611"),
Guid.Parse("1f67fcd8-361d-4333-a0d7-20143f152e12"),
Guid.Parse("96eb1f31-043c-4814-b582-7c9592f1d5b3"),
},
    NullableValue = 
new System.Guid[4]
{
Guid.Parse("ff6f1923-ca35-4f49-b9d9-4b988d553b0c"),
Guid.Parse("5a4a3d2e-50ae-4a63-ade1-7fb19bf7ed52"),
Guid.Parse("bf22bc09-00a2-418c-af3c-cefed8bce93f"),
Guid.Parse("abdd17c2-6689-4c7b-862c-6bb182c39859"),
},
},
    NullableValue = null,
},
            new GuidMArrayD1E1M
{
    Id = 189,
    Value = 
new System.Guid[4]
{
Guid.Parse("6e769be4-f4ac-491b-9a2c-7c562281ff41"),
Guid.Parse("e8082d95-cfc8-435f-96c3-1f3d547bc813"),
Guid.Parse("7bda3a1a-d2e3-4acc-9273-1b93cc7c72e2"),
Guid.Parse("8d7e4651-b53f-48b5-8554-be039e03eff2"),
},
    ModelInner = new GuidMArrayD1E1MI
{
    Id = 167,
    Value = 
new System.Guid[3]
{
Guid.Parse("6441554e-7d98-4ac5-bfac-d70b867d6edf"),
Guid.Parse("d421917f-69be-4dc1-8353-4cdc097a715d"),
Guid.Parse("d5a0819a-257d-467d-a7ff-deae33d2f93d"),
},
    NullableValue = null,
},
    NullableValue = 
new System.Guid[3]
{
Guid.Parse("c8db5969-d129-4417-b27f-c0a91760e7d3"),
Guid.Parse("8808e5c0-b579-4a0b-94a2-84452f2a8cfa"),
Guid.Parse("ba912365-be29-48f5-9881-779af941e1bc"),
},
},
        };

#endregion

#region InsertModelInner

#endregion

#region InsertModel

[Gedaq.DbConnection.Attributes.Query(
            query: @"
INSERT INTO gedaqtests.guidmarrayd1e1m(
	m_id,
    m_value,
    mi_id,
    mi_value
)
VALUES (
    {m_id:Int32},
    {m_value:Array(UUID)}, 
    {mi_id:Int32},
    {mi_value:Array(UUID)}
)
",
            methodName:"InsertModelDbConnection",
            queryMapTypes: null,
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.NonQuery,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "m_id", 
                methodParametrName: "m_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
                parametrName: "m_value", 
                methodParametrName: "m_Value"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Int32), 
                parametrName: "mi_id", 
                methodParametrName: "mi_Id"),
            Gedaq.DbConnection.Attributes.Parametr(
                parametrType: typeof(System.Guid[]), 
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
                    await ((IGuidMArrayMArrayD1)this).InsertModelDbConnectionAsync(
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
                     ((IGuidMArrayMArrayD1)this).InsertModelDbConnection(
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
FROM gedaqtests.guidmarrayd1e1m
WHERE
    m_id = {m_id:Int32}
",
            methodName:"SelectModelDbConnection",
            queryMapTypes: [typeof(GuidMArrayD1E1M)],
            methodType: MethodType.Async | MethodType.Sync,
            queryType: QueryType.Read,
            generate: true,
            accessModifier: AccessModifier.Public,
            asPartInterface: typeof(IGuidMArrayMArrayD1)),
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
                    var models = await ((IGuidMArrayMArrayD1)this).SelectModelDbConnectionAsync(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
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
                    var models =  ((IGuidMArrayMArrayD1)this).SelectModelDbConnection(
                        connection,
                        m_id: _testData[i].Id);
                    Assert.That(models, Has.Count.EqualTo(1));
                    GuidMArrayD1E1M.AssertModel(models[0],_testData[i], false);
                }
            }
        }

#endregion

    }
}

